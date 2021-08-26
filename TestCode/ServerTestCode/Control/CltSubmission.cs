
using Newtonsoft.Json;
using ServerTestCode.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerTestCode.Control
{
    class CltSubmission
    {
        DataProvider dataProvider;
        private string strCmdCompileCpp = "g++.exe ";

        public CltSubmission()
        {
            dataProvider = new DataProvider();
        }

        public long createSubmission(int accountId, int problemId)
        {
            List<SqlParam> sqlParamsIn = new List<SqlParam>();
            sqlParamsIn.Add(new SqlParam("@accountId", accountId));
            sqlParamsIn.Add(new SqlParam("@problemId", problemId));

            List<SqlParam> sqlParamsOut = new List<SqlParam>(1);
            sqlParamsOut.Add(new SqlParam("@result", 0));

            string sql = "exec proc_AddSubmission_Acc_Pro @accountId, @problemId, @result out";

            List<object> list = dataProvider.excuteProc(sql, sqlParamsIn, sqlParamsOut);
            //return (long)list[0];
            return Convert.ToInt64(list[0]);
        }

        public Submission getSubmission(long submissionId)
        {
            Submission submission = new Submission(submissionId);

            string sql = "SELECT * FROM func_GetSubmissionID(@submissionID)";
            List<SqlParam> sqlParams = new List<SqlParam>();
            sqlParams.Add(new SqlParam("@submissionID", submissionId));
            DataTable data = dataProvider.excuteFunc(sql, sqlParams);

            submission.AccountID = int.Parse(data.Rows[0][1].ToString());
            submission.ProblemID = int.Parse(data.Rows[0][2].ToString());
            submission.TimeSubmit = DateTime.Now;

            return submission;
        }

        public List<Submission> getSubmission(int accountId, int testId)
        {
            List<Submission> submissions = new List<Submission>();

            string sql = "SELECT * FROM func_GetSubmissionAccount(@accountId, @testId) order by TimeSubmit DESC";
            List<SqlParam> sqlParams = new List<SqlParam>();
            sqlParams.Add(new SqlParam("@accountId", accountId));
            sqlParams.Add(new SqlParam("@testId", testId));

            DataTable data = dataProvider.excuteFunc(sql, sqlParams);
            DataRowCollection dataRow = data.Rows;
            foreach (DataRow row in dataRow)
            {
                submissions.Add(new Submission(long.Parse(row[0].ToString()), int.Parse(row[1].ToString()),
                    int.Parse(row[2].ToString()), row[3].ToString(), row[4].ToString(), row[5].ToString(), 
                    DateTime.Parse(row[6].ToString()), int.Parse(row[7].ToString())));
            }
            return submissions;
        }

        public string getRequestListSubmission(int accountId, int testId)
        {
            List<Submission> submissions = getSubmission(accountId, testId);

            string srcFile = @"D:\Server\" + DateTime.Now.ToString("MMddhhmmssffff") + ".json";
            using (StreamWriter writer = File.CreateText(srcFile))
            {
                JsonSerializer jsonSerializer = new JsonSerializer();
                jsonSerializer.Serialize(writer, submissions);
            }
            return srcFile;
        }

        public void updateSubmission(Submission submission)
        {
            string sql = "EXEC proc_UpdateSubmission @submissionId, @accountId, @problemId, @result, @timeRun, @timeSubmit, @numOfTestCase, @res OUT";
            List<SqlParam> sqlParamsIn = new List<SqlParam>();
            sqlParamsIn.Add(new SqlParam("@submissionId", submission.SubmissonId));
            sqlParamsIn.Add(new SqlParam("@accountId", submission.AccountID));
            sqlParamsIn.Add(new SqlParam("@problemId", submission.ProblemID));
            sqlParamsIn.Add(new SqlParam("@result", submission.Result));
            sqlParamsIn.Add(new SqlParam("@timeRun", submission.TimeRun));
            sqlParamsIn.Add(new SqlParam("@timeSubmit", submission.TimeSubmit));
            sqlParamsIn.Add(new SqlParam("@numOfTestCase", submission.NumOfTestCase));

            List<SqlParam> sqlParamsOut = new List<SqlParam>();
            sqlParamsOut.Add(new SqlParam("@res",0));

            dataProvider.excuteProc(sql, sqlParamsIn, sqlParamsOut);
        }

        public Submission Marking(long submissionId, string srcFile)
        {
            Console.WriteLine($"Reading file {srcFile}");
            Submission submission = getSubmission(submissionId);
            submission.SubmissonId = submissionId;
            submission.TimeRun = "---";

            int indexFileExtension = srcFile.IndexOf('.', srcFile.Length - 4);
            string fileExtensionExe = srcFile.Replace(srcFile.Substring(indexFileExtension), ".exe");

            string srcFileFolder = srcFile.Substring(0, srcFile.LastIndexOf('\\'));

            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.CreateNoWindow = false;
            process.StartInfo.Verb = "runas administrator";
            process.Start();

            process.StandardInput.WriteLine("cd " + srcFileFolder);
            process.StandardInput.WriteLine(strCmdCompileCpp + srcFile + " -o " + fileExtensionExe);
            process.StandardInput.Close();
            if (!process.WaitForExit(5000))
            {
                process.Kill();
                submission.Result = $"Error: Compile error {process.StandardError.ReadToEnd().ToString()}";
                return submission;
            }
            string error = process.StandardError.ReadToEnd().ToString();

            Console.WriteLine($"Compiling file {fileExtensionExe}");
            //Console.WriteLine(process.StandardOutput.ReadToEnd());
            //submission.Result = process.StandardOutput.ReadToEnd();
            //process.WaitForExit();

            if (process.ExitCode != 0 || error.IndexOf("error") != -1)
            {
                submission.Result = "Error: Compile error";
                return submission;
            }
            else
            {
                submission.Result = "Compile Successful";
            }

            process.Close();
            Console.WriteLine($"Compile Successful {fileExtensionExe}");

            CltTestCase cltTestCase = new CltTestCase();
            List<TestCase> testCases = cltTestCase.getTestCase(submission.ProblemID);
            submission.NumOfTestCase = testCases.Count;

            int countOfTestCase = 0;
            foreach (TestCase testCase in testCases)
            {
                string input = "";
                if (testCase.Input != null && testCase.Input != "")
                {
                    input = File.ReadAllText(testCase.Input);
                }
                string outputResult = File.ReadAllText(testCase.Output);
                string output = "";

                process.StartInfo.FileName = fileExtensionExe;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardInput = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.CreateNoWindow = false;
                process.StartInfo.Verb = "runas administrator";

                //process.StandardInput.WriteLine(input);
                //process.StandardInput.Close();

                process.Start();
                if (testCase.Input != null && testCase.Input != "")
                {
                    process.StandardInput.WriteLine(input);
                    process.StandardInput.Close();
                }

                if (!process.WaitForExit(5000))
                {
                    process.Kill();
                    submission.Result = "Time limit";
                    return submission;
                }
                output = process.StandardOutput.ReadLine();

                int timeRun = (process.ExitTime - process.StartTime).Milliseconds;
                Console.WriteLine($"{countOfTestCase} {timeRun}ms");
                submission.TimeRun = $"{timeRun} ms";
                if (output == outputResult)
                {
                    countOfTestCase++;
                }
            }
            if (countOfTestCase == submission.NumOfTestCase)
            {
                submission.Result = "Accept";
            }
            else
            {
                submission.Result = $"Accept {countOfTestCase}\\{submission.NumOfTestCase}";
            }

            return submission;
        }
    }
}

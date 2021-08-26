using Newtonsoft.Json;
using ServerTestCode.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerTestCode.Control
{
    class CltTest
    {
        private DataProvider dataProvider;

        public CltTest()
        {
            dataProvider = new DataProvider();
        }

        public List<Test> getListTest()
        {
            string sql = "SELECT * FROM TEST";
            DataTable data = dataProvider.excuteFunc(sql, null);
            List<Test> tests = new List<Test>();
            DataRowCollection rowCollection = data.Rows;
            foreach (DataRow row in rowCollection)
            {
                tests.Add(new Test(int.Parse(row[0].ToString()), row[1].ToString(),
                    int.Parse(row[2].ToString()), DateTime.Parse(row[3].ToString()), null));
            }
            return tests;
        }

        public string getResponseListTest()
        {
            string srcFile = @"D:\Server\" + DateTime.Now.ToString("MMddhhmmssffff") + ".json";

            List<Test> tests = getListTest();

            using (StreamWriter writer = File.CreateText(srcFile))
            {
                JsonSerializer jsonSerializer = new JsonSerializer();
                jsonSerializer.Serialize(writer, tests);
            }

            return srcFile;
        }
        
        public int updateTest(int testID, string testName, int timeTest, DateTime timeStart)
        {
            int res = 0;
            string query = "exec proc_UpdateTest @testID, @testName, @timeTest, @timeStart, @res OUT";

            List<SqlParam> sqlParamIns = new List<SqlParam>();
            sqlParamIns.Add(new SqlParam("@testID", testID));
            sqlParamIns.Add(new SqlParam("@testName", testName));
            sqlParamIns.Add(new SqlParam("@timeTest", timeTest));
            sqlParamIns.Add(new SqlParam("@timeStart", timeStart));

            List<SqlParam> sqlParamOuts = new List<SqlParam>();
            sqlParamOuts.Add(new SqlParam("@res", 0));

            List<object> result = dataProvider.excuteProc(query, sqlParamIns, sqlParamOuts);

            res = (int)result[0];

            return res;
        }

        public int deleteTest(int testID)
        {
            int res = 0;
            string query = "exec proc_DeleteTest @testID, @res OUT";

            List<SqlParam> sqlParamIns = new List<SqlParam>();
            sqlParamIns.Add(new SqlParam("@testID", testID));

            List<SqlParam> sqlParamOuts = new List<SqlParam>();
            sqlParamOuts.Add(new SqlParam("@res", 0));

            List<object> result = dataProvider.excuteProc(query, sqlParamIns, sqlParamOuts);

            res = (int)result[0];

            return res;
        }

        public DataTable searchTest(string search)
        {
            List<SqlParam> sqlParams = new List<SqlParam>();
            sqlParams.Add(new SqlParam("@search", search));

            return dataProvider.excuteFunc("select * from dbo.func_SearchTest(@search)", sqlParams);
        }

        public DataTable loadTest()
        {
            string query = "select * from func_SearchTest('')";
            return dataProvider.excuteFunc(query, null);
        }

        public int addTest(string testName, int timeTest, DateTime timeStart)
        {
            string sql = "EXEC proc_AddTest @testName, @timeTest, @timeStart, @result OUT";

            List<SqlParam> sqlParamIns = new List<SqlParam>();
            sqlParamIns.Add(new SqlParam("@testName", testName));
            sqlParamIns.Add(new SqlParam("@timeTest", timeTest));
            sqlParamIns.Add(new SqlParam("@timeStart", timeStart));

            List<SqlParam> sqlParamOuts = new List<SqlParam>();
            sqlParamOuts.Add(new SqlParam("@result", 0));

            List<object> result = dataProvider.excuteProc(sql, sqlParamIns, sqlParamOuts);

            return (int)result[0];
        }

        public int relaseTest(string srcTest)
        {
            if (!File.Exists(srcTest))
            {
                return -1;
            }

            string srcDirectorySubName = Path.GetDirectoryName(srcTest) + "\\" + Path.GetFileNameWithoutExtension(srcTest);
            string SrcFolder = srcDirectorySubName;

            if (Path.GetExtension(srcTest) != ".zip")
            {
                return -2;
            }

            //ZipFile.CreateFromDirectory(srcTest, @"D:\Khoa\zzz.zip");

            if (Directory.Exists(srcDirectorySubName))
            {
                Directory.Delete(srcDirectorySubName, true);
            }

            ZipFile.ExtractToDirectory(srcTest, srcDirectorySubName);


            string srcFileJson = $"{srcDirectorySubName}\\{Path.GetFileNameWithoutExtension(srcTest)}.json";

            if (!File.Exists(srcFileJson))
            {
                return -3;
            }


            JsonFile jsonFile;
            using (StreamReader reader = new StreamReader(srcFileJson))
            {
                string json = reader.ReadToEnd();
                jsonFile = JsonConvert.DeserializeObject<JsonFile>(json);
            }

            foreach (Problem problem in jsonFile.problems)
            {
                string problemContent = $"D:\\Server\\Problem\\{DateTime.Now.ToString("MMddhhmmssffff")}.pdf";
                File.Copy($"{srcDirectorySubName}{problem.Content}", problemContent);

                CltProblem cltProblem = new CltProblem();
                problem.ProblemId = cltProblem.addProblem(problem.ProblemName, problemContent, jsonFile.testId);

                foreach (TestCase testCase in problem.testCase)
                {
                    string testCaseInput = $"D:\\Server\\TestCase\\{DateTime.Now.ToString("MMddhhmmssffff")}.inp";
                    if (testCase.Input != null) {
                        File.Copy($"{srcDirectorySubName}{testCase.Input}", testCaseInput, true);
                    }

                    string testCaseOutput = $"D:\\Server\\TestCase\\{DateTime.Now.ToString("MMddhhmmssffff")}.out";
                    File.Copy($"{srcDirectorySubName}{testCase.Output}", testCaseOutput, true);

                    CltTestCase cltTestCase = new CltTestCase();
                    cltTestCase.addTestCase(testCase.Input == null ? null : testCaseInput, testCaseOutput, problem.ProblemId);
                }
            }
            return 1;
        }

        private class JsonFile
        {
            public int testId;
            public List<Problem> problems;
        }
    }
}

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
    class CltProblem
    {
        DataProvider dataProvider;

        public CltProblem()
        {
            dataProvider = new DataProvider();
        }

        public List<Problem> getListProblem(int testID)
        {
            List<SqlParam> sqlParams = new List<SqlParam>();
            sqlParams.Add(new SqlParam("@testID", testID));
            DataTable data = dataProvider.excuteFunc("select * from func_GetProblem(@testID)", sqlParams);

            DataRowCollection dataRow = data.Rows;
            List<Problem> problems = new List<Problem>();
            foreach (DataRow row in dataRow)
            {
                problems.Add(new Problem(int.Parse(row[0].ToString()),
                                        row[1].ToString(),
                                        Path.GetFileName(row[2].ToString()),
                                        null));
            }

            return problems;
        }

        public int addProblem(string problemName, string content, int testId)
        {
            string sql = "EXEC proc_AddProblem @problemName, @content, @testId, @result OUT";

            List<SqlParam> sqlParamIns = new List<SqlParam>();
            sqlParamIns.Add(new SqlParam("@problemName", problemName));
            sqlParamIns.Add(new SqlParam("@content", content));
            sqlParamIns.Add(new SqlParam("@testId", testId));

            List<SqlParam> sqlParamOuts = new List<SqlParam>();
            sqlParamOuts.Add(new SqlParam("@result", 0));

            List<object> result = dataProvider.excuteProc(sql, sqlParamIns, sqlParamOuts);
            return (int)result[0];
        }

        public string getProblemContent(int problemId)
        {
            List<SqlParam> sqlParams = new List<SqlParam>();
            sqlParams.Add(new SqlParam("@problemID ", problemId));
            DataTable data = dataProvider.excuteFunc("select * from func_GetProblemID(@problemID)", sqlParams);

            return data.Rows[0][2].ToString();
        }

        public string getProblemListRequest(int testID)
        {
            string srcFile = @"D:\Server\" + DateTime.Now.ToString("MMddhhmmssffff") + ".json";

            List<Problem> problems = getListProblem(testID);

            using (StreamWriter writer = File.CreateText(srcFile))
            {
                JsonSerializer jsonSerializer = new JsonSerializer();
                jsonSerializer.Serialize(writer, problems);
            }

            return srcFile;
        }

        public int updateProblem(int problemID, string problemName, string content, int testID)
        {
            int res = 0;
            string query = "exec proc_UpdateProblem @problemID, @problemName, @content, @testID, @res OUT";

            List<SqlParam> sqlParamIns = new List<SqlParam>();
            sqlParamIns.Add(new SqlParam("@problemID", problemID));
            sqlParamIns.Add(new SqlParam("@problemName", problemName));
            sqlParamIns.Add(new SqlParam("@content", content));
            sqlParamIns.Add(new SqlParam("@testID", testID));

            List<SqlParam> sqlParamOuts = new List<SqlParam>();
            sqlParamOuts.Add(new SqlParam("@res", 0));

            List<object> result = dataProvider.excuteProc(query, sqlParamIns, sqlParamOuts);

            res = (int)result[0];

            return res;
        }

        public int deleteProblem(int problemID)
        {
            int res = 0;
            string query = "exec proc_DeleteProblem @problemID, @res OUT";

            List<SqlParam> sqlParamIns = new List<SqlParam>();
            sqlParamIns.Add(new SqlParam("@problemID", problemID));

            List<SqlParam> sqlParamOuts = new List<SqlParam>();
            sqlParamOuts.Add(new SqlParam("@res", 0));

            List<object> result = dataProvider.excuteProc(query, sqlParamIns, sqlParamOuts);

            res = (int)result[0];

            return res;
        }

        public DataTable searchProblem (string search)
        {
            List<SqlParam> sqlParams = new List<SqlParam>();
            sqlParams.Add(new SqlParam("@search", search));

            return dataProvider.excuteFunc("select * from dbo.func_SearchProblem(@search)", sqlParams);
        }

        public DataTable loadProblem()
        {
            string query = "select * from func_SearchProblem('')";
            return dataProvider.excuteFunc(query, null);
        }

        public Problem createProblem(string problemName, string srcContent, string srcFolderInput, string srcFolderOutput)
        {
            Problem problem = new Problem(problemName, srcContent);
            problem.testCase = createTestCase(srcFolderInput, srcFolderOutput);
            return problem;
        }

        private List<TestCase> createTestCase(string srcInput, string srcOutput)
        {
            List<TestCase> testCases = new List<TestCase>();

            if (srcInput == null)
            {
                foreach (string file in Directory.EnumerateFiles(srcOutput))
                {
                    TestCase testCase = new TestCase(null, file);
                    Console.WriteLine(file);
                    testCases.Add(testCase);
                }
            }
            else
            {
                foreach (string file in Directory.EnumerateFiles(srcInput))
                {
                    Console.WriteLine(file);
                    string fileName = Path.GetFileNameWithoutExtension(file);

                    string fileOutput = Directory.EnumerateFiles(srcOutput, $"{fileName}.*").FirstOrDefault();
                    Console.WriteLine(fileOutput);

                    testCases.Add(new TestCase(file, fileOutput));
                }
            }

            return testCases;
        }
    }
}

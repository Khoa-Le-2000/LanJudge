using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    class CltTestCase
    {
        private DataProvider dataProvider;

        public CltTestCase()
        {
            dataProvider = new DataProvider();
        }

        public List<TestCase> getTestCase(int problemID)
        {
            List<SqlParam> sqlParams = new List<SqlParam>();
            sqlParams.Add(new SqlParam("@problemID", problemID));
            DataTable data = dataProvider.excuteFunc("select * from func_GetTestCase(@problemID)", sqlParams);

            List<TestCase> testcase = new List<TestCase>();

            DataRowCollection dataRow = data.Rows;
            foreach (DataRow row in dataRow)
            {
                testcase.Add(new TestCase(int.Parse(row[0].ToString()), row[1].ToString(), row[2].ToString()));
            }

            return testcase;
        }

        public int addTestCase(string input, string output, int problemID)
        {
            int @res = 0;
            string query = "exec proc_AddTestCase @input, @output, @problemID, @res OUT";

            List<SqlParam> sqlParamIns = new List<SqlParam>();
            sqlParamIns.Add(new SqlParam("@input", (object)input ?? DBNull.Value));
            sqlParamIns.Add(new SqlParam("@output", output));
            sqlParamIns.Add(new SqlParam("@problemID", problemID));

            List<SqlParam> sqlParamOuts = new List<SqlParam>();
            sqlParamOuts.Add(new SqlParam("@res", 0));

            List<Object> result = dataProvider.excuteProc(query, sqlParamIns, sqlParamOuts);

            res = (int)result[0];

            return res;
        }

        public int updateTestCase(int testcaseID, string input, string output, int problemID)
        {
            int res = 0;
            string query = "exec proc_UpdateTestCase @testcaseID, @input, @output, @problemID, @res OUT";

            List<SqlParam> sqlParamIns = new List<SqlParam>();
            sqlParamIns.Add(new SqlParam("@testcaseID", testcaseID));
            sqlParamIns.Add(new SqlParam("@input", input));
            sqlParamIns.Add(new SqlParam("@output", output));
            sqlParamIns.Add(new SqlParam("@problemID", problemID));

            List<SqlParam> sqlParamOuts = new List<SqlParam>();
            sqlParamOuts.Add(new SqlParam("@res", 0));

            List<Object> result = dataProvider.excuteProc(query, sqlParamIns, sqlParamOuts);

            res = (int)result[0];
            return res;
        }

        public int deleteTestCase(int testcaseID)
        {
            int res = 0;
            string query = "exec proc_DeleteTestCase @testcaseID, @res OUT";

            List<SqlParam> sqlParamIns = new List<SqlParam>();
            sqlParamIns.Add(new SqlParam("@testcaseID", testcaseID));

            List<SqlParam> sqlParamOuts = new List<SqlParam>();
            sqlParamOuts.Add(new SqlParam("@res", 0));

            List<Object> result = dataProvider.excuteProc(query, sqlParamIns, sqlParamOuts);

            res = (int)result[0];

            return res;      
        }
    }
}

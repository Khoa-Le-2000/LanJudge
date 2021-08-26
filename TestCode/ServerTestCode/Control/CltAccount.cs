using Newtonsoft.Json;
using ServerTestCode.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerTestCode.Control
{
    class CltAccount
    {
        private DataProvider dataProvider;

        public static Account Account;
        public CltAccount()
        {
            dataProvider = new DataProvider();
        }

        private int queryDataBase(string userName, string password)
        {
            List<SqlParam> sqlParams = new List<SqlParam>();
            sqlParams.Add(new SqlParam("@username", userName));
            sqlParams.Add(new SqlParam("@password", password));
            DataTable data = dataProvider.excuteFunc("select dbo.func_CheckLogin(@username,@password)", sqlParams);

            return int.Parse(data.Rows[0][0].ToString());
        }

        public Account getAccount(int accountId)
        {
            List<SqlParam> sqlParams = new List<SqlParam>();
            sqlParams.Add(new SqlParam("@accountID", accountId));
            DataTable data = dataProvider.excuteFunc("select * from func_GetAccount(@accountID)", sqlParams);

            Account account = new Account(int.Parse(data.Rows[0][0].ToString()), data.Rows[0][1].ToString(), 
                data.Rows[0][3].ToString(), data.Rows[0][4].ToString());

            return account;
        }
        public void ChangeFullName(string fullName)
        {
            string proc = "exec proc_ChangeFullName @accountId, @fullName, @res OUT";
            List<SqlParam> sqlParamIns = new List<SqlParam>();
            sqlParamIns.Add(new SqlParam("@accountId", Account.AccountID));
            sqlParamIns.Add(new SqlParam("@fullName", fullName));

            List<SqlParam> sqlParamOuts = new List<SqlParam>();
            sqlParamOuts.Add(new SqlParam("@res", 0));

            dataProvider.excuteProc(proc, sqlParamIns, sqlParamOuts);
        }
        public int ChangeFullName(int accountId, string fullName)
        {
            string proc = "exec proc_ChangeFullName @accountId, @fullName, @res OUT";
            List<SqlParam> sqlParamIns = new List<SqlParam>();
            sqlParamIns.Add(new SqlParam("@accountId", accountId));
            sqlParamIns.Add(new SqlParam("@fullName", fullName));

            List<SqlParam> sqlParamOuts = new List<SqlParam>();
            sqlParamOuts.Add(new SqlParam("@res", 0));

            List<object> result = dataProvider.excuteProc(proc, sqlParamIns, sqlParamOuts);

            return (int)result[0];
        }
        public int ChangePass(string oldpass, string newpass)
        {
            int res = 0;
            string proc = "exec proc_ChangePassword @accountId, @oldpass, @newpass, @res OUT";

            List<SqlParam> sqlParamIns = new List<SqlParam>();
            sqlParamIns.Add(new SqlParam("@accountId", Account.AccountID));
            sqlParamIns.Add(new SqlParam("@oldpass", oldpass));
            sqlParamIns.Add(new SqlParam("@newpass", newpass));

            List<SqlParam> sqlParamOuts = new List<SqlParam>();
            sqlParamOuts.Add(new SqlParam("@res", 0));

            List<object> result = dataProvider.excuteProc(proc, sqlParamIns, sqlParamOuts);

            res = (int)result[0];
            return res;
        }
        public int ChangePass(int accountId, string oldpass, string newpass)
        {
            int res = 0;
            string proc = "exec proc_ChangePassword @accountId, @oldpass, @newpass, @res OUT";

            List<SqlParam> sqlParamIns = new List<SqlParam>();
            sqlParamIns.Add(new SqlParam("@accountId", accountId));
            sqlParamIns.Add(new SqlParam("@oldpass", oldpass));
            sqlParamIns.Add(new SqlParam("@newpass", newpass));

            List<SqlParam> sqlParamOuts = new List<SqlParam>();
            sqlParamOuts.Add(new SqlParam("@res", 0));

            List<object> result = dataProvider.excuteProc(proc, sqlParamIns, sqlParamOuts);

            res = (int)result[0];
            return res;
        }

        public Account getAccount_userName(string userName)
        {
            List<SqlParam> sqlParams = new List<SqlParam>();
            sqlParams.Add(new SqlParam("@userName", userName));
            DataTable data = dataProvider.excuteFunc("select * from func_GetAccount_UserName(@userName)", sqlParams);

            Account account = new Account(int.Parse(data.Rows[0][0].ToString()), data.Rows[0][1].ToString(),
                data.Rows[0][3].ToString(), data.Rows[0][4].ToString());

            return account;
        }

        public DataTable searchAccount(string search)
        {
            List<SqlParam> sqlParams = new List<SqlParam>();
            sqlParams.Add(new SqlParam("@search", search));

            return dataProvider.excuteFunc("select * from dbo.func_SearchAccount(@search)", sqlParams);
        }

        public string checkLogin(string userName, string passwpord)
        {
            string fileResult = @"D:\Server\" + DateTime.Now.ToString("MMddhhmmssffff") + ".json";

            int accountId = queryDataBase(userName, passwpord);
            JsonFile jsonFile = new JsonFile();
            if (accountId >= 0)
            {
                jsonFile.Result = 1;
                jsonFile.Account = getAccount(accountId);
            }
            else
            {
                jsonFile.Result = 0;
                jsonFile.Account = null;
            }
            using (StreamWriter writer = File.CreateText(fileResult))
            {
                JsonSerializer jsonSerializer = new JsonSerializer();
                jsonSerializer.Serialize(writer, jsonFile);
            }

            return fileResult;
        }

        public Account checkLoginAdmin(string userName, string password)
        {
            int id = queryDataBase(userName, password);
            if (id < 0) return null;
            Account account = getAccount(id);
            return account;
        }

        public int addAccount(string userName, string password, string fullName, string permssion)
        {
            int res = 0;
            string proc = "exec proc_AddAccount @userName, @password, @fullName, @permission, @res out";

            List<SqlParam> sqlParamIns = new List<SqlParam>();
            sqlParamIns.Add(new SqlParam("@userName", userName));
            sqlParamIns.Add(new SqlParam("@password", password));
            sqlParamIns.Add(new SqlParam("@fullName", fullName));
            sqlParamIns.Add(new SqlParam("@permission", permssion));

            List<SqlParam> sqlParamOuts = new List<SqlParam>();
            sqlParamOuts.Add(new SqlParam("@res", 0));

            List<object> result = dataProvider.excuteProc(proc, sqlParamIns, sqlParamOuts);

            res = (int)result[0];

            return res;
        }

        public int updateAccount(int accoundID, string userName, string password, string fullName, string permssion)
        {
            int res = 0;
            string proc = "exec proc_UpdateAccount @accoundID, @userName, @password, @fullName, @permission, @res OUT";

            List<SqlParam> sqlParamIns = new List<SqlParam>();
            sqlParamIns.Add(new SqlParam("@accoundID", accoundID));
            sqlParamIns.Add(new SqlParam("@userName", userName));
            sqlParamIns.Add(new SqlParam("@password", password));
            sqlParamIns.Add(new SqlParam("@fullName", fullName));
            sqlParamIns.Add(new SqlParam("@permission", permssion));

            List<SqlParam> sqlParamOuts = new List<SqlParam>();
            sqlParamOuts.Add(new SqlParam("@res", 0));

            List<object> result = dataProvider.excuteProc(proc, sqlParamIns, sqlParamOuts);

            res = (int)result[0];

            return res;
        }

        public int deleteAccount(int accoundID)
        {
            int res = 0;
            string proc = "exec proc_DeleteAccount @accoundID, @res OUT";

            List<SqlParam> sqlParamIns = new List<SqlParam>();
            sqlParamIns.Add(new SqlParam("@accoundID", accoundID));

            List<SqlParam> sqlParamOuts = new List<SqlParam>();
            sqlParamOuts.Add(new SqlParam("@res", 0));

            List<object> result = dataProvider.excuteProc(proc, sqlParamIns, sqlParamOuts);

            res = (int)result[0];
            return res;
        }
        private class JsonFile
        {
            public int Result;
            public Account Account;
        }

        
        public DataTable loadAccount()
        {  
            string query = "select * from func_SearchAccount('')";
            return dataProvider.excuteFunc(query, null);
        }
    }
}

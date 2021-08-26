using ServerTestCode.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerTestCode.Control
{
    class DataProvider
    {
        private string connectionString = @"Data Source=AITD201506002\SQLEXPRESS;Initial Catalog=TestCode;Integrated Security=True";

        public void excuteProc(string query, List<SqlParam> sqlParams)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                if (sqlParams != null)
                    foreach (SqlParam param in sqlParams)
                        command.Parameters.AddWithValue(param.Name, param.Value);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                connection.Close();
            }
        }

        public List<object> excuteProc(string query, List<SqlParam> sqlParamsIn, List<SqlParam> sqlParamsOut)
        {
            List<object> list = new List<object>(sqlParamsOut.Capacity);
            using (SqlConnection connection = new SqlConnection(connectionString))
            using(SqlCommand command = new SqlCommand(query, connection))
            {
                command.CommandType = CommandType.Text;

                if (sqlParamsIn != null)
                {
                    foreach (SqlParam sqlParam in sqlParamsIn)
                    {
                        command.Parameters.AddWithValue(sqlParam.Name, sqlParam.Value);
                    }
                }

                if (sqlParamsOut != null)
                {
                    foreach (SqlParam sqlParam in sqlParamsOut)
                    {
                        command.Parameters.AddWithValue(sqlParam.Name, sqlParam.Value).Direction = ParameterDirection.Output;
                    }
                }

                connection.Open();
                command.ExecuteNonQuery();

                foreach (SqlParam sqlParam in sqlParamsOut)
                {
                    list.Add(command.Parameters[sqlParam.Name].Value);
                }
            }

            return list;
        }



        public DataTable excuteFunc(string query, List<SqlParam> sqlParams)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                if (sqlParams != null)
                    foreach (SqlParam param in sqlParams)
                        command.Parameters.AddWithValue(param.Name, param.Value);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                sqlDataAdapter.Fill(data);
                connection.Close();
            }
            return data;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DataTableTo.Domain.Model;

namespace DataTableTo.Infra.Repositories
{
    public class UserDataRepository : IUserDataRepository
    {
        const string COLUMN_NAME = "COLUMN_NAME";
        const string DATA_TYPE = "DATA_TYPE";
        const string PARAMETER_TABLE_NAME = "@tableName";

        public void FillTableData(UserData dt)
        {
            using (var conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnString(dt);

                var cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = GetQueryFieldsName();
                cmd.Parameters.AddWithValue(PARAMETER_TABLE_NAME, dt.TableName);
                conn.Open();

                var data = cmd.ExecuteReader();
                var tbData = new List<TableData>();

                while (data.Read())
                {
                    if (IsInvalidData(data))
                        continue;

                    var tableData = new TableData
                    {
                        ColumnName = data[COLUMN_NAME].ToString(),
                        ColumnType = data[DATA_TYPE].ToString()
                    };

                    tbData.Add(tableData);
                }

                dt.TableData = tbData;

                data.Close();
                conn.Close();
            }
        }

        private bool IsInvalidData(SqlDataReader data)
        {
            return DBNull.Value.Equals(data[COLUMN_NAME]) || DBNull.Value.Equals(data[DATA_TYPE]);
        }

        private string GetQueryFieldsName()
        {
            return $@"SELECT COLUMN_NAME, DATA_TYPE
                      FROM INFORMATION_SCHEMA.COLUMNS
                      WHERE TABLE_NAME = {PARAMETER_TABLE_NAME}";
        }

        private string GetConnString(UserData userData)
        {
            var connStr = new SqlConnectionStringBuilder();
            connStr.DataSource = userData.Server;
            connStr.InitialCatalog = userData.Database;
            connStr.UserID = userData.Login;
            connStr.Password = userData.Password;
            return connStr.ToString();
        }

        public bool IsConnectedSqlServer(UserData userData)
        {
            bool connected;

            using (var conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnString(userData);
                conn.Open();
                connected = ConnectionState.Open.Equals(conn.State);
                conn.Close();
            }

            return connected;
        }
    }
}

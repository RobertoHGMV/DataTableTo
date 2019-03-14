using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DataTableTo.Domain.Model;

namespace DataTableTo.Infra.Repositories
{
    public class UserDataRepository : IUserDataRepository
    {
        private const string COLUMN_NAME = "COLUMN_NAME";
        private const string DATA_TYPE = "DATA_TYPE";

        public void FillTableData(UserData dt)
        {
            using (var conn = new SqlConnection())
            {
                //conn.ConnectionString = $"Server={dt.Server};Database={dt.Database};User={dt.Login};Password={dt.Password}";
                conn.ConnectionString = GetConnString(dt);

                var cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = GetQueryFieldsName(dt.TableName);
                conn.Open();

                var data = cmd.ExecuteReader();
                var tbData = new List<TableData>();

                while (data.Read())
                {
                    if (DBNull.Value.Equals(data[COLUMN_NAME]) || DBNull.Value.Equals(data[DATA_TYPE]))
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

        private string GetQueryFieldsName(string tableName)
        {
            return $@"
                    DECLARE @tableName NVARCHAR(200)
                    SET @tableName = '{tableName}'
                    
                    SELECT COLUMN_NAME, DATA_TYPE
                    FROM INFORMATION_SCHEMA.COLUMNS
                    WHERE TABLE_NAME = ''+ @tableName +''";
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
                connected = ConnectionState.Open == conn.State;
                conn.Close();
            }

            return connected;
        }
    }
}

using System;
using System.Data.SqlClient;
using System.Linq;
using DataTableTo.Domain.Model;

namespace DataTableTo.Infra.Repositories
{
    public class UserDataRepository : IUserDataRepository
    {
        public void FillResults(UserData dt)
        {
            dt.ValidateParamsToFillResults();
            dt.ValidateConfiguration();

            using (var conn = new SqlConnection())
            {
                conn.ConnectionString = $"Server={dt.Server};Database={dt.Database};User={dt.Login};Password={dt.Password}";

                var cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = GetQuery(dt.TableName, dt.ColumnPrefix);
                conn.Open();

                var data = cmd.ExecuteReader();
                while (data.Read())
                {
                    if (DBNull.Value.Equals(data["result"]))
                        continue;

                    var result = data["result"].ToString();
                    dt.Results.ToList().Add(result);
                }

                data.Close();
                conn.Close();
            }
        }

        private string GetQuery(string tableName, string prefix)
        {
            if (!string.IsNullOrEmpty(prefix))
                prefix = prefix + ".";

            return $@"
                      SELECT result = REPLACE(REPLACE(
                      ''+ CAST(
                      			CASE DATA_TYPE
                      				WHEN 'int'      THEN ''+ CAST(COLUMN_NAME AS NVARCHAR) +' = row[{prefix}'+ CAST(COLUMN_NAME AS NVARCHAR) +']'
                      				WHEN 'nvarchar' THEN ''+ CAST(COLUMN_NAME AS NVARCHAR) +' = row[{prefix}'+ CAST(COLUMN_NAME AS NVARCHAR) +']'
                      				WHEN 'nchar'    THEN ''+ CAST(COLUMN_NAME AS NVARCHAR) +' = row[{prefix}'+ CAST(COLUMN_NAME AS NVARCHAR) +']'
                      				WHEN 'datetime' THEN ''+ CAST(COLUMN_NAME AS NVARCHAR) +' = row[{prefix}'+ CAST(COLUMN_NAME AS NVARCHAR) +']'
                      				WHEN 'decimal'  THEN ''+ CAST(COLUMN_NAME AS NVARCHAR) +' = row[{prefix}'+ CAST(COLUMN_NAME AS NVARCHAR) +']'
                      				WHEN 'money'    THEN ''+ CAST(COLUMN_NAME AS NVARCHAR) +' = row[{prefix}'+ CAST(COLUMN_NAME AS NVARCHAR) +']'
                      				WHEN 'bit'      THEN ''+ CAST(COLUMN_NAME AS NVARCHAR) +' = !DBNull.Value.Equals(row[{prefix}'+ CAST(COLUMN_NAME AS NVARCHAR) +']) && row[{prefix}'+ CAST(COLUMN_NAME AS NVARCHAR) +']'
                      			 END AS NVARCHAR(MAX)) +'
                      '+ CAST(
                      			CASE DATA_TYPE
                      				WHEN 'int'      THEN '?.To<int'
                      				WHEN 'nvarchar' THEN '.To<string'
                      				WHEN 'nchar' THEN '.To<string'
                      				WHEN 'datetime' THEN '.To<DateTime'
                      				WHEN 'decimal'  THEN '?.To<decimal'
                      				WHEN 'money'  THEN '?.To<decimal'
                      				WHEN 'bit'      THEN '.To<bool'
                      			 END AS NVARCHAR(MAX)) +'>() 
                      			 '+ CAST(
                      			CASE DATA_TYPE
                      				WHEN 'int'      THEN ' ?? 0'
                      				WHEN 'nvarchar' THEN ''
                      				WHEN 'nchar' THEN ''
                      				WHEN 'datetime' THEN ''
                      				WHEN 'decimal'  THEN ' ?? 0'
                      				WHEN 'money'  THEN ' ?? 0'
                      				WHEN 'bit'      THEN ''
                      			 END AS NVARCHAR(MAX)) +';'
                      			 ,
                      			 CHAR(13) + Char(10) ,' '), CHAR(10), '')
                      FROM INFORMATION_SCHEMA.COLUMNS
                      WHERE TABLE_NAME = '{tableName}'";
        }
    }
}

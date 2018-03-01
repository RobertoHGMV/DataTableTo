using System;
using System.Collections.Generic;
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

                var queryToExec = !dt.CustomMehtodExtension
                    ? GetFormatedFromTo(dt.TableName, dt.ColumnPrefix, dt.ColumnSufix)
                    : GetFormatedFromTo(dt.TableName, dt.ColumnPrefix, dt.ColumnSufix, dt.MethodExtension);

                var cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = queryToExec;
                conn.Open();

                var data = cmd.ExecuteReader();

                var results = new List<string>();
                while (data.Read())
                {
                    if (DBNull.Value.Equals(data["result"]))
                        continue;

                    var result = data["result"].ToString();
                    results.Add(result);
                }

                dt.Results = results;

                data.Close();
                conn.Close();
            }
        }

        private string GetFormatedFromTo(string tableName, string prefix, string sufix)
        {
            if (!string.IsNullOrEmpty(prefix))
                prefix = prefix + ".";

            return $@"
                    DECLARE @tableName NVARCHAR(200), 
                    		@prefix    NVARCHAR(200), 
                    		@sufix     NVARCHAR(200)
                    
                    SET @tableName = '{tableName}'
                    SET @prefix    = '{prefix}'
                    SET @sufix     = '{sufix}'
                    
                    SELECT result = REPLACE(REPLACE(
                                          ''+ CAST(
                                          			CASE DATA_TYPE
                                          				WHEN 'int'      THEN ''+ CAST(COLUMN_NAME AS NVARCHAR) +' = !DBNull.Value.Equals(row['+ @prefix + CAST(COLUMN_NAME AS NVARCHAR) + @sufix +']) ? Convert.ToInt32(row['+ @prefix + CAST(COLUMN_NAME AS NVARCHAR) + @sufix +']) : 0;'
                                          				WHEN 'nvarchar' THEN ''+ CAST(COLUMN_NAME AS NVARCHAR) +' = row['+ @prefix + CAST(COLUMN_NAME AS NVARCHAR) + @sufix +'].ToString();'
                                          				WHEN 'nchar'    THEN ''+ CAST(COLUMN_NAME AS NVARCHAR) +' = row['+ @prefix + CAST(COLUMN_NAME AS NVARCHAR) + @sufix +'].ToString();'
                                          				WHEN 'decimal'  THEN ''+ CAST(COLUMN_NAME AS NVARCHAR) +' = !DBNull.Value.Equals(row['+ @prefix + CAST(COLUMN_NAME AS NVARCHAR) + @sufix +']) ? Convert.ToDecimal(row['+ @prefix + CAST(COLUMN_NAME AS NVARCHAR) + @sufix +']) : 0;'
                                          				WHEN 'money'    THEN ''+ CAST(COLUMN_NAME AS NVARCHAR) +' = !DBNull.Value.Equals(row['+ @prefix + CAST(COLUMN_NAME AS NVARCHAR) + @sufix +']) ? Convert.ToDecimal(row['+ @prefix + CAST(COLUMN_NAME AS NVARCHAR) + @sufix +']) : 0;'
                                          				WHEN 'bit'      THEN ''+ CAST(COLUMN_NAME AS NVARCHAR) +' = !DBNull.Value.Equals(row['+ @prefix + CAST(COLUMN_NAME AS NVARCHAR) + @sufix +']) && Convert.ToBoolean(row['+ @prefix + CAST(COLUMN_NAME AS NVARCHAR) + @sufix +']);'
                    									WHEN 'datetime' THEN 'if (!DBNull.Value.Equals(row['+ @prefix + CAST(COLUMN_NAME AS NVARCHAR) + @sufix +'])) '+ CAST(COLUMN_NAME AS NVARCHAR) +' = Convert.ToDateTime(row['+ @prefix + CAST(COLUMN_NAME AS NVARCHAR) + @sufix +']);'
                                          			 END AS NVARCHAR(MAX)),
                                          			 CHAR(13) + Char(10) ,' '), CHAR(10), '')
                                          FROM INFORMATION_SCHEMA.COLUMNS
                                          WHERE TABLE_NAME = ''+ @tableName +''";
        }

        private string GetFormatedFromTo(string tableName, string prefix, string sufix, string methodExtension)
        {
            if (!string.IsNullOrEmpty(prefix))
                prefix = prefix + ".";

            return $@"
                    DECLARE @tableName NVARCHAR(200), 
                    		@prefix    NVARCHAR(200), 
                    		@sufix     NVARCHAR(200)
                    
                    SET @tableName = '{tableName}'
                    SET @prefix    = '{prefix}'
                    SET @sufix     = '{sufix}'
                    
                    SELECT result = REPLACE(REPLACE(
                                          ''+ CAST(
                                          			CASE DATA_TYPE
                                          				WHEN 'int'      THEN ''+ CAST(COLUMN_NAME AS NVARCHAR) +' = row['+ @prefix + CAST(COLUMN_NAME AS NVARCHAR) + @sufix +']?.{methodExtension}<int>() ?? 0;'
                                          				WHEN 'nvarchar' THEN ''+ CAST(COLUMN_NAME AS NVARCHAR) +' = row['+ @prefix + CAST(COLUMN_NAME AS NVARCHAR) + @sufix +'].{methodExtension}<string>();'
                                          				WHEN 'nchar'    THEN ''+ CAST(COLUMN_NAME AS NVARCHAR) +' = row['+ @prefix + CAST(COLUMN_NAME AS NVARCHAR) + @sufix +'].{methodExtension}<string>();'                      				
                                          				WHEN 'decimal'  THEN ''+ CAST(COLUMN_NAME AS NVARCHAR) +' = row['+ @prefix + CAST(COLUMN_NAME AS NVARCHAR) + @sufix +']?.{methodExtension}<decimal>() ?? 0;'
                                          				WHEN 'money'    THEN ''+ CAST(COLUMN_NAME AS NVARCHAR) +' = row['+ @prefix + CAST(COLUMN_NAME AS NVARCHAR) + @sufix +']?.{methodExtension}<decimal>() ?? 0;'
                                          				WHEN 'bit'      THEN ''+ CAST(COLUMN_NAME AS NVARCHAR) +' = !DBNull.Value.Equals(row['+ @prefix + CAST(COLUMN_NAME AS NVARCHAR) + @sufix +']) && row['+ @prefix + CAST(COLUMN_NAME AS NVARCHAR) + @sufix +'].{methodExtension}<bool>();'
                    									WHEN 'datetime' THEN 'if (!DBNull.Value.Equals(row['+ @prefix + CAST(COLUMN_NAME AS NVARCHAR) + @sufix +'])) '+ CAST(COLUMN_NAME AS NVARCHAR) +' = row['+ @prefix + CAST(COLUMN_NAME AS NVARCHAR) + @sufix +'].{methodExtension}<DateTime>();'
                                          			 END AS NVARCHAR(MAX)),
                                          			 CHAR(13) + Char(10) ,' '), CHAR(10), '')
                                          FROM INFORMATION_SCHEMA.COLUMNS
                                          WHERE TABLE_NAME = ''+ @tableName +''";
        }
    }
}

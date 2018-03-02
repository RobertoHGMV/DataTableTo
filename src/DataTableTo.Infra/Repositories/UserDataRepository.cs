using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using DataTableTo.Domain.Model;

namespace DataTableTo.Infra.Repositories
{
    public class UserDataRepository : IUserDataRepository
    {
        private const string COLUMN_NAME = "COLUMN_NAME";
        private const string DATA_TYPE = "DATA_TYPE";

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

        public void FillTableData(UserData dt)
        {
            using (var conn = new SqlConnection())
            {
                conn.ConnectionString = $"Server={dt.Server};Database={dt.Database};User={dt.Login};Password={dt.Password}";

                var cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = System.Data.CommandType.Text;
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
    }
}

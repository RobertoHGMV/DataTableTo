using System;
using System.Collections.Generic;

namespace DataTableTo.Domain.Model
{
    public class UserData
    {
        public UserData()
        {
            Results = new List<string>();
        }

        public string TableName { get; set; }

        public string ColumnPrefix { get; set; }

        public string ColumnSufix { get; set; }

        public bool CustomMehtodExtension { get; set; }

        public string MethodExtension { get; set; }

        public string Server { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string Database { get; set; }

        public IEnumerable<string> Results { get; set; }

        public void ValidateParamsToFillResults()
        {
            if (string.IsNullOrEmpty(TableName))
                throw new Exception("Nome da tabela não informado");

            if (string.IsNullOrEmpty(ColumnPrefix))
                throw new Exception("Prefix da coluna não informado");

            if (string.IsNullOrEmpty(ColumnSufix))
                throw new Exception("Sufixo da coluna não informado");
        }

        public void ValidateConfiguration()
        {
            if (string.IsNullOrEmpty(Server))
                throw new Exception("Servidor não informado");

            if (string.IsNullOrEmpty(Login))
                throw new Exception("Login não informado");

            if (string.IsNullOrEmpty(Password))
                throw new Exception("Senha não informada");

            if (string.IsNullOrEmpty(Database))
                throw new Exception("Banco de dados não informado");

            if (CustomMehtodExtension && string.IsNullOrEmpty(MethodExtension))
                throw new Exception("Método de extensão não informado");
        }
    }
}

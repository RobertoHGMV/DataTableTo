using System.Text;
using DataTableTo.Domain.Services;

namespace DataTableTo.Domain.Model.FromToCreation.MethodPatern
{
    public class FromToMethodString : IFromToMethod
    {
        public void CreateFromTo(IFromToService fromToService, StringBuilder sb, UserData userData, TableData data)
        {
            if (!SameType(data.ColumnType)) return;

            sb.Append(userData.Method.Replace(userData.typeParam, "string").Replace(userData.fieldParam, data.ColumnName));
        }

        public bool SameType(string type) => "nvarchar".Equals(type) || "varchar".Equals(type) || "nchar".Equals(type);
    }
}

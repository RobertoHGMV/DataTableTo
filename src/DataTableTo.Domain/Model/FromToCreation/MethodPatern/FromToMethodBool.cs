using System.Text;
using DataTableTo.Domain.Services;

namespace DataTableTo.Domain.Model.FromToCreation.MethodPatern
{
    public class FromToMethodBool : IFromToMethod
    {
        public void CreateFromTo(IFromToService fromToService, StringBuilder sb, UserData userData, TableData data)
        {
            if (!SameType(data.ColumnType)) return;
            
            sb.Append(userData.Method.Replace(userData.typeParam, "bool").Replace(userData.fieldParam, data.ColumnName));
        }

        public bool SameType(string type) =>
            "bit".Equals(type)
            || "boolean".Equals(type);
    }
}

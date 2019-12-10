using System.Text;
using DataTableTo.Domain.Services;

namespace DataTableTo.Domain.Model.FromToCreation.DotNetPatern
{
    public class FromToDotNetDecimal : IFromToDotNet
    {
        public void CreateFromTo(IFromToService fromToService, StringBuilder sb, UserData userData, TableData data)
        {
            if (!SameType(data.ColumnType)) return;

            sb.Append(userData.ObjectName);
            sb.Append(data.ColumnName);
            sb.Append(" = !DBNull.Value.Equals(");
            fromToService.FillDataRow(sb, userData, data);
            sb.Append(") ? ");
            sb.Append("Convert.ToDecimal(");
            fromToService.FillDataRow(sb, userData, data);
            sb.Append(") : 0;");
        }

        public bool SameType(string type) => 
            "decimal".Equals(type) 
            || "money".Equals(type);
    }
}

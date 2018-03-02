using System.Text;
using DataTableTo.Domain.Services;

namespace DataTableTo.Domain.Model.FromToCreation.CustomPatern
{
    public class FromToCustomBool : IFromToCustom
    {
        public void CreateFromTo(IFromToService fromToService, StringBuilder sb, UserData userData, TableData data)
        {
            if (!SameType(data.ColumnType)) return;

            sb.Append(data.ColumnName);
            sb.Append(" = !DBNull.Value.Equals(");
            fromToService.FillDataRow(sb, userData, data);
            sb.Append(") && ");
            fromToService.FillDataRow(sb, userData, data);
            sb.Append(".");
            sb.Append(userData.MethodExtension);
            sb.Append("<bool>();");
        }

        public bool SameType(string type) => "bit".Equals(type);
    }
}

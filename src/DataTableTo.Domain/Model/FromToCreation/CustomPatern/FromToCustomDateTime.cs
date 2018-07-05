using System.Text;
using DataTableTo.Domain.Services;

namespace DataTableTo.Domain.Model.FromToCreation.CustomPatern
{
    public class FromToCustomDateTime : IFromToCustom
    {
        public void CreateFromTo(IFromToService fromToService, StringBuilder sb, UserData userData, TableData data)
        {
            if (!SameType(data.ColumnType)) return;

            sb.Append("if (!DBNull.Value.Equals(");
            fromToService.FillDataRow(sb, userData, data);
            sb.Append(")) ");
            sb.Append("\n");
            sb.Append("    ");
            sb.Append(userData.ObjectName);
            sb.Append(data.ColumnName);
            sb.Append(" = ");
            fromToService.FillDataRow(sb, userData, data);
            sb.Append(".");
            sb.Append(userData.MethodExtension);
            sb.Append("<DateTime>();");
        }

        public bool SameType(string type) => "datetime".Equals(type);
    }
}

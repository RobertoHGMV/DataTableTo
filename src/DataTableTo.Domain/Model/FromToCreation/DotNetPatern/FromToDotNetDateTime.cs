using System.Text;
using DataTableTo.Domain.Services;

namespace DataTableTo.Domain.Model.FromToCreation.DotNetPatern
{
    public class FromToDotNetDateTime : IFromToDotNet
    {
        public void CreateFromTo(IFromToService fromToService, StringBuilder sb, UserData userData, TableData data)
        {
            if (!SameType(data.ColumnType)) return;

            sb.Append("if (!DBNull.Value.Equals(");
            fromToService.FillDataRow(sb, userData, data);
            sb.Append(")) ");
            sb.Append("\n");
            sb.Append("    ");
            sb.Append(data.ColumnName);
            sb.Append(" = ");
            sb.Append("Convert.ToDateTime(");
            fromToService.FillDataRow(sb, userData, data);
            sb.Append(")");
        }

        public bool SameType(string type) => "datetime".Equals(type);
    }
}

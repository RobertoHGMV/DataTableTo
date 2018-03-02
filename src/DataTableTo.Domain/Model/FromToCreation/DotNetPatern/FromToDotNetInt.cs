using System.Text;
using DataTableTo.Domain.Services;

namespace DataTableTo.Domain.Model.FromToCreation.DotNetPatern
{
    public class FromToDotNetInt : IFromToDotNet
    {
        public void CreateFromTo(IFromToService fromToService, StringBuilder sb, UserData userData, TableData data)
        {
            if (!SameType(data.ColumnType)) return;

            sb.Append(data.ColumnName);
            sb.Append(" = !DBNull.Value.Equals(");
            fromToService.FillDataRow(sb, userData, data);
            sb.Append(") ? ");
            sb.Append("Convert.ToInt32(");
            fromToService.FillDataRow(sb, userData, data);
            sb.Append(") : 0;");
        }

        public bool SameType(string type) => "int".Equals(type);
    }
}

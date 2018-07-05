using System.Text;
using DataTableTo.Domain.Services;

namespace DataTableTo.Domain.Model.FromToCreation.DotNetPatern
{
    public class FromToDotNetString : IFromToDotNet
    {
        public void CreateFromTo(IFromToService fromToService, StringBuilder sb, UserData userData, TableData data)
        {
            if (!SameType(data.ColumnType)) return;

            sb.Append(userData.ObjectName);
            sb.Append(data.ColumnName);
            sb.Append(" = ");
            fromToService.FillDataRow(sb, userData, data);
            sb.Append(".ToString();");
        }

        public bool SameType(string type) => "nvarchar".Equals(type) || "nchar".Equals(type);
    }
}

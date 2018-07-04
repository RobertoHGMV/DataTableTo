using System.Text;
using DataTableTo.Domain.Services;

namespace DataTableTo.Domain.Model.FromToCreation.GenericPatern
{
    public class FromToGeneric : IFromToGeneric
    {
        public void CreateFromTo(IFromToService fromToService, StringBuilder sb, UserData userData, TableData data)
        {
            sb.Append(data.ColumnName);
            sb.Append(" = ");
            fromToService.FillRow(sb, userData, data);
        }
    }
}

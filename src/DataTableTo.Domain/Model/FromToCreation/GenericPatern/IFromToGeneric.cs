using System.Text;
using DataTableTo.Domain.Services;

namespace DataTableTo.Domain.Model.FromToCreation.GenericPatern
{
    public interface IFromToGeneric
    {
        void CreateFromTo(IFromToService fromToService, StringBuilder sb, UserData userData, TableData data);
    }
}

using DataTableTo.Domain.Services;
using System.Text;

namespace DataTableTo.Domain.Model.FromToCreation.MethodPatern
{
    public interface IFromToMethod
    {
        void CreateFromTo(IFromToService fromToService, StringBuilder sb, UserData userData, TableData data);

        bool SameType(string type);
    }
}

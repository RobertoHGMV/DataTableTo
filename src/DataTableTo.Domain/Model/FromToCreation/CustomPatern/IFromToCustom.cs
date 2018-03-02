using DataTableTo.Domain.Services;
using System.Text;

namespace DataTableTo.Domain.Model.FromToCreation.CustomPatern
{
    public interface IFromToCustom
    {
        void CreateFromTo(IFromToService fromToService, StringBuilder sb, UserData userData, TableData data);

        bool SameType(string type);
    }
}

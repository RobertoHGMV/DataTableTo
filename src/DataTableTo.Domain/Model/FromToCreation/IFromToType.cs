using DataTableTo.Domain.Services;

namespace DataTableTo.Domain.Model.FromToCreation
{
    public interface IFromToType
    {
        void CreateFromType(IFromToService fromToService, UserData userData); 
    }
}

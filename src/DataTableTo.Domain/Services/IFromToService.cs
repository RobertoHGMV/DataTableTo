using DataTableTo.Domain.Model;
using DataTableTo.Domain.Model.FromToCreation;
using System.Text;

namespace DataTableTo.Domain.Services
{
    public interface IFromToService
    {
        void CreateFromTo(IFromToType fromToType, UserData userData);

        void FillDataRow(StringBuilder sb, UserData userData, TableData data);

        void FillRow(StringBuilder sb, UserData userData, TableData data);
    }
}

namespace DataTableTo.Domain.Model
{
    public interface IUserDataRepository
    {
        void FillTableData(UserData dt);
        void FillTableDataByDataTable(UserData userData);
        bool IsConnectedSqlServer(UserData userData);
    }
}

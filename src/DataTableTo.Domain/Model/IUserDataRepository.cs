namespace DataTableTo.Domain.Model
{
    public interface IUserDataRepository
    {
        void FillTableData(UserData dt);
        bool IsConnectedSqlServer(UserData userData);
    }
}

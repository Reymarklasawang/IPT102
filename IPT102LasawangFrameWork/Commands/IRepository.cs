using Dapper;

namespace IPT102LasawangFrameWork.Commands
{
    public interface IRepository
    {
        Task GetDataAsync<T>(string connectionName, string storeProcedureName, DynamicParameters parameters);
        Task<bool> SaveDataAsync(string connectionName, string storedProcedureName, DynamicParameters p);
    }
}
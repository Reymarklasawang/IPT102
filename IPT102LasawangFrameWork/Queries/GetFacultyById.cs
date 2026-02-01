using IPT102Framework.Extensions;
using IPT102LasawangDomain.Models;
using IPT102LasawangRepository.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace IPT102Framework.Queries;

public class GetFacultyById
{
    private readonly IRepository _repository;
    private readonly string _connectionName = "DefaultConnection";
    private readonly string _storedProcedureName = "[dbo].[GetCourseById]";

    public GetFacultyById(IRepository repository)
    {
        _repository = repository;
    }

    public async Task<FacultyModel?> ExecuteAsync(string id)
    {
        var parameters = id.ToDynamicParameters("Id");

        var result = await _repository.GetDataAsync<FacultyModel>(
            _connectionName,
            _storedProcedureName,
            parameters
        );

        return result.FirstOrDefault();
    }
}

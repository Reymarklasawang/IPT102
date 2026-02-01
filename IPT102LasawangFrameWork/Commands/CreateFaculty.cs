using IPT102LasawangDomain.Commands;
using IPT102LasawangDomain.Models;         
using IPT102LasawangFrameWork.Extensions;
using IPT102LasawangRepository;
using IPT102LasawangRepository.Interfaces;
using System.Threading.Tasks;

namespace IPT102LasawangFrameWork.Commands;

public class CreateFaculty : ICreateFaculty
{
    private readonly string _connectionName = "DefaultConnection";
    private readonly string _storedProcedureName = "[dbo].[CreateFaculty]";
    private readonly IRepository _repository;

    public CreateFaculty(IRepository repository)
    {
        _repository = repository;
    }

    public async Task<bool> ExecuteAsync(FacultyModel model)
    {
        var p = model.ToFacultyDynamicParameters();
        return await _repository.SaveDataAsync(_connectionName, _storedProcedureName, p);
    }
}

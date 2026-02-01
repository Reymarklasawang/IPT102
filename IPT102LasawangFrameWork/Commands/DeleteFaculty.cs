using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPT102LasawangDomain.Commands;
using IPT102LasawangDomain.Models;
using IPT102LasawangFrameWork.Extensions;
using IPT102LasawangRepository.Interfaces;

namespace IPT102LasawangFrameWork.Commands;

public class DeleteFaculty : IDeleteFaculty
{
    private readonly string _connectionName = "DefaultConnection";
    private readonly string _storedProcedureName;
    private readonly IRepository _repository;

    public DeleteFaculty(IRepository reposository)
    {
        _storedProcedureName = "[dbo].[DeleteFaculty]";
        _repository = _repository;
    }

    public async Task<bool> ExecuteAsync(FacultyModel model)
    {
        var p = model.ToFacultyDynamicParameters();
        return await _repository.SaveDataAsync(_connectionName, _storedProcedureName, p);
    }
}

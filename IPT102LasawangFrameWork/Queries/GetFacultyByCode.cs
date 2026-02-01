using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using IPT102LasawangDomain.Models;
using IPT102LasawangDomain.Queries;
using IPT102Framework.Extensions;
using IPT102LasawangRepository.Interfaces;

namespace IPT102LasawangFrameWork.Queries;

public class GetFacultyByCode : IGetFacultyByCode
{
    private readonly string _connectionName = "DefaultConnection";
    private readonly string _storeProcedureName;
    private readonly IRepository _repository;

    public GetFacultyByCode(IRepository repository)
    {
        _storeProcedureName = "[dbo].[GetCourseByCode]";
        _repository = repository;
    }

    public async Task<FacultyModel?> ExecuteAsync(string code)
    {
        var parameters = code.ToDynamicParameters("Code");
        var data = await _repository.GetDataAsync<FacultyModel>(_connectionName, _storeProcedureName, parameters);

        return data.FirstOrDefault();
    }
}

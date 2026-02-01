using IPT102LasawangDomain.Models;

namespace IPT102LasawangDomain.Queries;

public interface IGetFacultyByCode
{
    Task<FacultyModel?> ExecuteAsync(string code);
}

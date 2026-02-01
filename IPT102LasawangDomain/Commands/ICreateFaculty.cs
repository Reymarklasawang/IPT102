using IPT102LasawangDomain.Models;

namespace IPT102LasawangDomain.Commands;

public interface ICreateFaculty
{
    Task<bool> ExecuteAsync(FacultyModel model);
}

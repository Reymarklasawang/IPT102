using IPT102LasawangDomain.Models;

namespace IPT102LasawangDomain.Commands;

public interface IUpdateFaculty
{
    Task<bool> ExecuteAsync(FacultyModel model);
}

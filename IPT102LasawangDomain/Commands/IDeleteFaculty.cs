using IPT102LasawangDomain.Models;

namespace IPT102LasawangDomain.Commands;

public interface IDeleteFaculty
{
    Task<bool> ExecuteAsync(FacultyModel model);
}

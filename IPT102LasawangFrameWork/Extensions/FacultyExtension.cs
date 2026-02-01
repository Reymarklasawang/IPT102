using System.Data;
using Dapper;
using IPT102LasawangDomain.Models;   

namespace IPT102LasawangFrameWork.Extensions;

public static class FacultyExtension
{
	public static DynamicParameters ToFacultyDynamicParameters(this FacultyModel model)
	{
		var p = new DynamicParameters();

		p.Add("@Id", model.FacultyId, DbType.String, ParameterDirection.Input);
		p.Add("@Code", model.FacultyCode, DbType.String, ParameterDirection.Input);
		p.Add("@Title", model.FacultyTitle, DbType.String, ParameterDirection.Input);
		p.Add("@Credit", model.FacultyCredit, DbType.Double, ParameterDirection.Input);

		return p;
	}
}

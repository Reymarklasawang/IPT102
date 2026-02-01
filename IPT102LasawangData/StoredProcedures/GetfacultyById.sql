CREATE PROCEDURE [dbo].[GetfacultyById]
	@Code NVARCHAR(24) = NULL
AS
BEGIN
	-- checks

	SELECT a.[Id] AS FacultyId,
		a.[Code] AS FacultyCode,
		a.[Title] AS FacultyTitle,
		a.[Credit] AS FacultyCredit
	FROM [dbo].[Faculty] AS a
	WHERE a.[Code] = @Code
END
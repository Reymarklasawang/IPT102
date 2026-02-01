CREATE PROCEDURE [dbo].[Deletefaculty]
	@Id NVARCHAR(40) = NULL
AS
BEGIN
	
	IF LEN(LTRIM(RTRIM(COALESCE(@Id, N'')))) = 0 RETURN;

	DELETE FROM [dbo].[Faculty]
	WHERE [Id] = @Id;
END
CREATE PROCEDURE [dbo].[Updatefaculty]
@Id NVARCHAR(40) = NULL,
	@Code NVARCHAR(24) = NULL,
	@Title NVARCHAR(128) = NULL,
	@Credit NUMERIC(5, 2) = NULL
AS
BEGIN
	-- checks
	-- Return;

	UPDATE [dbo].[Faculty]
	SET [Code] = @Code,
		[Title] = @Title,
		[Credit] = @Credit
	WHERE [Id] = @Id;
END
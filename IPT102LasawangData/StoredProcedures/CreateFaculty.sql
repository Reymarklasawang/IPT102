CREATE PROCEDURE [dbo].[CreateFaculty]
@Id NVARCHAR(40) = NULL,
	@Code NVARCHAR(24) = NULL,
	@Title NVARCHAR(128) = NULL,
	@Credit NUMERIC(5, 2) = NULL
AS
BEGIN
	

	INSERT INTO [dbo].[Faculty]([Id], [Code], [Title], [Credit])
	VALUES (@Id, @Code, @Title, @Credit)
END
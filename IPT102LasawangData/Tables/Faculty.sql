CREATE TABLE [dbo].[Faculty]
(
	[Id] NVARCHAR(40) NOT NULL,
	[Code] NVARCHAR(24),
	[Title] NVARCHAR(128),
	[Credit] NUMERIC(5, 2),

	CONSTRAINT PK_Faculty_ID PRIMARY KEY CLUSTERED ([Id] ASC)
);
GO

CREATE NONCLUSTERED INDEX [IX_Faculty_Code] ON [dbo].[Faculty] ([Code] ASC)
WHERE [Code] IS NOT NULL;

CREATE TABLE [dbo].[Controls]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(100) NOT NULL,
	[BreadId] int NOT NULL, 
    CONSTRAINT [FK_Controls_To_Breads] FOREIGN KEY ([BreadId]) REFERENCES [Breads]([Id])
)

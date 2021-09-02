CREATE TABLE [dbo].[LaunchInstances]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[BreadId] INT NOT NULL, 
	[MinutesPassed] INT NOT NULL, 
	[Status] NVARCHAR(100) NOT NULL, 
	[CreatedAt] DATETIME NOT NULL, 
    CONSTRAINT [FK_LaunchInstances_To_Breads] FOREIGN KEY ([BreadId]) REFERENCES [Breads]([Id]),
)

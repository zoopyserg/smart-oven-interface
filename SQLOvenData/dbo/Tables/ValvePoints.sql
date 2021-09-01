CREATE TABLE [dbo].[ValvePoints]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Minute] INT NOT NULL,
	[Value] BINARY(50) NOT NULL,
	[BreadId] INT NOT NULL, 
    CONSTRAINT [FK_ValvePoints_To_Breads] FOREIGN KEY ([BreadId]) REFERENCES [Breads]([Id]),
)

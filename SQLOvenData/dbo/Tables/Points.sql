CREATE TABLE [dbo].[Points]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Minute] INT NOT NULL,
	[Value] BINARY(50) NOT NULL,
	[ControlId] INT NOT NULL,
	[BreadId] INT NOT NULL, 
    CONSTRAINT [FK_Points_To_Breads] FOREIGN KEY ([BreadId]) REFERENCES [Breads]([Id]),
	CONSTRAINT [FK_Points_To_Controls] FOREIGN KEY ([ControlId]) REFERENCES [Controls]([Id])
)

CREATE TABLE [dbo].[PressurePoints]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Minute] INT NOT NULL,
	[Value] BINARY(50) NOT NULL,
	[BreadId] INT NOT NULL, 
    CONSTRAINT [FK_PressirePoints_To_Breads] FOREIGN KEY ([BreadId]) REFERENCES [Breads]([Id]),
)

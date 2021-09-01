CREATE TABLE [dbo].[TemperaturePoints]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Minute] INT NOT NULL,
	[Value] BINARY(50) NOT NULL,
	[BreadId] INT NOT NULL, 
    CONSTRAINT [FK_TemperaturePoints_To_Breads] FOREIGN KEY ([BreadId]) REFERENCES [Breads]([Id]),
)

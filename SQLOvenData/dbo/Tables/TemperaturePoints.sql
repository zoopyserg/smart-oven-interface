CREATE TABLE [dbo].[TemperaturePoints]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Minute] INT NOT NULL,
	[Value] INT NOT NULL,
	[BreadId] INT NOT NULL, 
    CONSTRAINT [FK_TemperaturePoints_To_Breads] FOREIGN KEY ([BreadId]) REFERENCES [Breads]([Id]),
)

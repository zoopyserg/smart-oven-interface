CREATE VIEW [dbo].[FullBread]
	AS 
	SELECT [b].[Id] AS BookId, 
	       [b].[Name] AS BookName, 
		   [t].[Id] AS ControlId, 
		   [t].[Minute] AS TemperaturePointMinute,
		   [t].[Value] AS TemperaturePointValue
	FROM dbo.Breads b
	LEFT JOIN dbo.TemperaturePoints t on b.Id = t.BreadId

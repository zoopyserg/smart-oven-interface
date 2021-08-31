CREATE VIEW [dbo].[FullBread]
	AS 
	SELECT [b].[Id] AS BookId, 
	       [b].[Name] AS BookName, 
		   [c].[Id] AS ControlId, 
		   [c].[Name] AS ControlName
	FROM dbo.Breads b
	LEFT JOIN dbo.Controls c on b.Id = c.BreadId

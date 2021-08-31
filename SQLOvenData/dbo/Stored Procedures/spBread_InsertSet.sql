CREATE PROCEDURE [dbo].[spBread_InsertSet]
	@breads BasicUDT readonly
AS
BEGIN
	INSERT INTO dbo.Breads(Name)
	SELECT [Name]
	FROM @breads
END

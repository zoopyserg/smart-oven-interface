CREATE PROCEDURE [dbo].[spBreads_GetById]
	@ID int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT *
	FROM dbo.Breads
	WHERE id = @ID;
END
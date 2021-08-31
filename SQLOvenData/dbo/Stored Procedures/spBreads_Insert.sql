CREATE PROCEDURE [dbo].[spBreads_Insert]
    @NAME nvarchar(100)
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO dbo.Breads (Name)
	VALUES (@NAME)
END

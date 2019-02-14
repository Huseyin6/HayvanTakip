
ALTER PROCEDURE [dbo].[spKarZarar]
	
AS
BEGIN
	SET NOCOUNT ON;
	declare @sumGelir decimal(18,0)
	declare @sumGider decimal(18,0)

	SET @sumGelir=(select sum(Tutar) from Gelir)
	SET @sumGider=(select sum(Tutar) from Gider)
	select format(@sumGelir-@sumGider,'#,##')
END

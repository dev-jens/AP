CREATE OR ALTER VIEW [dbo].[V_PLAYERS_RETIRED]
AS
SELECT
	*
FROM
	dbo.SPELERS s
where 
	(
		DATEDIFF(yy,s.GEB_DATUM, getdate()) = 65 AND
		DATEPART(dayofyear, getdate()) >= datepart(dayofyear,s.geb_datum)
	)
	OR
	(
		DATEDIFF(yy,s.geb_datum,getdate()) > 65
	)

GO

SELECT * FROM  [dbo].[V_PLAYERS_RETIRED]
GO
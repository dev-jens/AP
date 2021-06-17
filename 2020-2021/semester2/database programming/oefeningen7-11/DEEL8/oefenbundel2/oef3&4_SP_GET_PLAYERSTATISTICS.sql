CREATE OR ALTER PROCEDURE [dbo].[SP_GET_PLAYERSTATISTICS]
	@prm_playernr INT
AS
BEGIN
	DECLARE @var_result VARCHAR(512)
	DECLARE @var_name VARCHAR(20)
	DECLARE @var_numberoffines INT
	DECLARE @var_numberofgames INT

	SET @var_name = (
						SELECT
							TRIM([NAAM])
						FROM
							[dbo].[SPELERS]
						WHERE
							[SPELERSNR] = @prm_playernr
					);
	SET @var_numberoffines = (
								SELECT		
									COUNT(*)
								FROM
									[dbo].[BOETES]
								WHERE
									[SPELERSNR] = @prm_playernr
							  );
	SET @var_numberofgames = (
								SELECT
									COUNT(*)
								FROM
									[dbo].[WEDSTRIJDEN]
								WHERE
									[SPELERSNR] = @prm_playernr
							 );
	SET @var_result = CONCAT(
								'Speler ''',
								@var_name,
								''' heeft ',
								@var_numberofgames,
								' wedstrijd(en) gespeeld en ',
								@var_numberoffines,
								' boete(s) ontvangen.'
							);
	SELECT @var_result
END;
GO

EXEC SP_GET_PLAYERSTATISTICS 6;
GO 
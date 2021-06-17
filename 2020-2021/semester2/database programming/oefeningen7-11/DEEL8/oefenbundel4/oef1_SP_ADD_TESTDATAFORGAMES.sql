CREATE OR ALTER PROCEDURE [dbo].[SP_ADD_TESTDATAFORGAMES]
(
	@prm_gamescount INT
)
AS
BEGIN
	IF @prm_gamescount IS NULL OR @prm_gamescount NOT BETWEEN 1 AND 5
		BEGIN
			PRINT 'Please supply a number between 1 and 5!';
		END
	ELSE
		BEGIN
			DECLARE @var_playercount INT;
			DECLARE @var_playerindex INT;
			DECLARE @var_playernumber INT;
			DECLARE @var_gameindex INT;
			DECLARE @var_scoreid INT;
			DECLARE @var_newgameid INT;
			DECLARE @var_gewonnen INT;
			DECLARE @var_verloren INT;

			CREATE TABLE #tempscores(ID INT, GEWONNEN INT, VERLOREN INT);
			INSERT INTO #tempscores VALUES
			(1,0,3),
			(2,1,3),
			(3,2,3),
			(4,3,0),
			(5,3,1),
			(6,3,2);

			SET @var_playerindex = 1;
			SET @var_playercount = (SELECT COUNT(*) FROM [dbo].[SPELERS]);

			WHILE @var_playerindex <= @var_playercount
			BEGIN
				SET @var_playernumber = (
											SELECT
												SPELERSNR
											FROM
												(
													SELECT	
														ROW_NUMBER() OVER (ORDER BY [SPELERSNR]) AS ROWNUMBER,
														[SPELERSNR]
													FROM
														[dbo].[SPELERS]
												)temp
												WHERE
													ROWNUMBER = @var_playerindex
										);
				SET @var_gameindex = 1;

				WHILE @var_gameindex <= @prm_gamescount
				BEGIN
					SET @var_newgameid = (SELECT MAX([WEDSTRIJDNR]) FROM [dbo].[WEDSTRIJDEN]) + 1;
					SET @var_scoreid = (SELECT ROUND(1 + (RAND() * 5),0))

					SELECT
						@var_gewonnen = GEWONNEN,
						@var_verloren = VERLOREN
					FROM
						#tempscores
					WHERE
						ID = @var_scoreid;

					INSERT INTO [dbo].[WEDSTRIJDEN] VALUES
					(@var_newgameid, (SELECT ROUND(1 + (RAND() * 1),0)),@var_playernumber,@var_gewonnen,@var_verloren);
					SET @var_gameindex = @var_gameindex + 1;
				END

				SET @var_playerindex = @var_playerindex + 1;
			END
		END
END
GO
CREATE OR ALTER PROCEDURE [dbo].[SP_SAVE_GAME]
(
	@prm_gamenr INT,
	@prm_teamnr INT,
	@prm_playernr INT,
	@prm_gewonnen SMALLINT,
	@prm_verloren SMALLINT
)
AS
BEGIN
	DECLARE @var_player_exists INT
	DECLARE @var_game_exists INT

	IF @prm_playernr IS NULL
		PRINT 'Please supply a (valid) playernr!';
	ELSE
		BEGIN
			SET @var_player_exists = (SELECT COUNT(*) FROM [dbo].[SPELERS] WHERE [SPELERSNR] = @prm_playernr);

			IF @var_player_exists = 0
				PRINT CONCAT('Player with number ', @prm_playernr, ' does not exist!');
			ELSE
				BEGIN
					SET @var_game_exists = (SELECT COUNT(*) FROM [dbo].[WEDSTRIJDEN] WHERE [SPELERSNR] = @prm_playernr);

					IF @var_game_exists = 0
						INSERT INTO [dbo].[WEDSTRIJDEN] VALUES
						(@prm_gamenr,@prm_teamnr,@prm_playernr,@prm_gewonnen,@prm_verloren);
					ELSE
						UPDATE [dbo].[WEDSTRIJDEN] SET
							TEAMNR = @prm_teamnr,
							SPELERSNR = @prm_playernr,
							GEWONNEN = @prm_gewonnen,
							VERLOREN = @prm_verloren
						WHERE
							WEDSTRIJDNR = @prm_gamenr;
				END
		END
END
GO
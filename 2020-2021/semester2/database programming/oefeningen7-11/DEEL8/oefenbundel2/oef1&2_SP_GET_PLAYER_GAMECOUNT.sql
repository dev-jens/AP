CREATE OR ALTER PROCEDURE SP_GET_PLAYER_GAMECOUNT
	@prm_spelernr INT,
	@prm_gamcount INT OUT
AS
BEGIN
	SET @prm_gamcount = (SELECT COUNT(*) FROM [dbo].[WEDSTRIJDEN] WHERE [SPELERSNR] = @prm_spelernr);
END
GO

DECLARE @var_gameCount int;
SET @var_gameCount =0;

EXEC SP_GET_PLAYER_GAMECOUNT 6,@var_gameCount OUT;

SELECT @var_gameCount
GO


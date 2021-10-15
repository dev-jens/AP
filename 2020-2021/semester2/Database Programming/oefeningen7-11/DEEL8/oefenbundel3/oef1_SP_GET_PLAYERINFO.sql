CREATE OR ALTER PROCEDURE [dbo].[SP_GET_PLAYERINFO]
	@prm_playernr INT
AS
BEGIN
	IF @prm_playernr IS NULL
		PRINT 'Please supply a (valid) playernr!';
	ELSE
		BEGIN
			SELECT
				*
			FROM
				[dbo].[SPELERS]
			WHERE
				[SPELERSNR] = @prm_playernr
			;
		END
END;
GO 
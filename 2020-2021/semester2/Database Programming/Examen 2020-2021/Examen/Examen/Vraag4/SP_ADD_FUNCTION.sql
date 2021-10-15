CREATE OR ALTER PROCEDURE SP_ADD_FUNCTION
(	@prm_spelernr int,
	@prm_beginDatum date,
	@prm_einddatum date,
	@prm_functie char
)
AS
BEGIN 
	if @prm_functie <> 'lid' and @prm_functie <> 'penningmeester' and @prm_functie <> 'secretaris' and @prm_functie <> 'voorzitter'
		print concat(@prm_functie,'is geen juiste invoer')
	ELSE
	BEGIN
		if @prm_spelernr is not null
		begin
			if @prm_einddatum is not null
				begin
					INSERT INTO [dbo].[BESTUURSLEDEN] VALUES(@prm_spelernr,@prm_beginDatum,@prm_einddatum,@prm_functie);
				end
			else
				begin
					INSERT INTO [dbo].[BESTUURSLEDEN] VALUES(@prm_spelernr,@prm_einddatum,null,@prm_functie);
				end
		end
		else
			print 'speler bestaat niet'
	END
END

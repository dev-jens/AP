SELECT 
	[s].[NAAM],
	[s].[VOORLETTERS],
	[v].[GAMESPLAYED],
	[v].[GAMESWON],
	[v].[GAMESLOST],
	[v].[NUMBEROFFINES],
	[v].[TOTALFINESAMOUNT]
FROM
	[dbo].[V_PLAYERS_STATS] [v]
	INNER JOIN [dbo].[SPELERS] [s] ON [v].[SPELERSNR] = [s].[SPELERSNR]
GO 
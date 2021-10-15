select 
	s.`spelersnr`,
    w.`teamnr`
from 
	`spelers` s 
    left join `wedstrijden`w ON s.`SPELERSNR` = w.`SPELERSNR`;
    
SELECT 
	s.`spelersnr`,
    COALESCE(b.`bedrag`,0)
FROM 
	`SPELERS` s
    left join `boetes` b on s.`spelersnr` = b.`spelersnr`;

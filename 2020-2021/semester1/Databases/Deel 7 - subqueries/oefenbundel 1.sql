SELECT 
    (SELECT 
            `DIVISIE`
        FROM
            `TEAMS`
        WHERE
            `teamnr` = 1) AS tem1,
    (SELECT 
            `DIVISIE`
        FROM
            `TEAMS`
        WHERE
            `teamnr` = 2) AS tem2;
            
-- 2 
SELECT 
	s.`spelersnr`,
    (
		select 
			count(`spelersnr`)
		from
			`wedstrijden` w
		where
			s.`spelersnr` = w.`spelersnr`
    
        ) as aantal
from
	`spelers` s









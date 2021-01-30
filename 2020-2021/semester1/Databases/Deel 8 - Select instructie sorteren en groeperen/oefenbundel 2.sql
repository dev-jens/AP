/*SELECT 
	*	
FROM
	`SPELERS`
ORDER BY
	`NAAM` DESC;
    
-- 2 
SELECT
	*
FROM 
	`SPELERS`
ORDER BY 
	`JAARTOE` , `PLAATS`, `NAAM` DESC ;
    
-- 3
SELECT
	`NAAM`,
    `VOORLETTERS`,
    `SPELERSNR`
FROM
	`spelers`
ORDER BY
	RIGHT(`NAAM`,1) DESC;
 */   
-- 4

SELECT 
	s.`naam`,
    (select
		count(*)
	 from 
		`boetes` b
	where 
		s.`SPELERSNR` = b.`SPELERSNR`
     ) as aantal
from
	`spelers` s 
    inner join `boetes` b ON s.`SPELERSNR` = b.`SPELERSNR`
-- 1
SELECT 
    `betalingsnr`, `bedrag`
FROM
    `boetes`
WHERE
    `bedrag` IN (50 , 75, 100);

-- 2
SELECT 
    *
FROM
    `wedstrijden`
WHERE
    `spelersnr` NOT IN (8 , 27, 112);

-- 3 
select
	`SPELERSNR`,
    `NAAM`,
    `STRAAT`
from 
	`SPELERS`
where
	LEFT(`STRAAT`,1) in ('e' ,'l','s');
-- 4
SELECT 
	`SPELERSNR`,
    `JAARTOE`,
     year(current_date) - `JAARTOE` AS AANTAL_JAREN,
    `GEB_DATUM`,
    CASE 
		WHEN YEAR(CURRENT_DATE) - `JAARTOE` >= 45 THEN '+45'
        WHEN  YEAR(CURRENT_DATE) - `JAARTOE` >= 40 THEN '+40'
		WHEN YEAR(CURRENT_DATE) - `JAARTOE` >= 35 THEN '+35'
    END AS DUURTIJD 
FROM 
	`SPELERS`
WHERE 
	YEAR(`GEB_DATUM`) IN (1956,1963,1970);
    
    

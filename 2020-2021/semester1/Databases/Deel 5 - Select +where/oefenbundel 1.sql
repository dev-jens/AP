-- 1
SELECT 
    `BETALINGSNR`, `BEDRAG`
FROM
    `BOETES`
WHERE
    `BEDRAG` > 60;
    
-- 2
SELECT 
    `SPELERSNR`,
    `GEWONNEN`,
    `VERLOREN`,
    `GEWONNEN` + `VERLOREN` AS AANTAL_SETS
FROM
    `wedstrijden`
WHERE
    `GEWONNEN` + `VERLOREN` = 5;
    
-- 3 
SELECT 
    `NAAM`, `PLAATS`
FROM
    `SPELERS`
WHERE
    `PLAATS` = 'Den Haag'
        OR `PLAATS` = 'Rijswijk';

-- 4 
SELECT 
    `NAAM`, `GESLECHT`, `PLAATS`
FROM
    `SPELERS`
WHERE
    `GELESCHT` = 'V'
        AND `PLAATS` = 'Zoetermeer';
    
-- 5
SELECT
	*
FROM
	`BOETES`
WHERE 
	`spelersnr` = 44 and year(`datum`) = 1980 or 
    month(`datum`) <> 12  ;

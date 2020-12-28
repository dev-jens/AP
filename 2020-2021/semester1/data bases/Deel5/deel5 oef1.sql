/* SELECT 
    `BETALINGSNR`, `BEDRAG`
FROM
    `BOETES`
WHERE
    `BEDRAG` > 60;
    


SELECT 
	`SPELERSNR`, `GEWONNEN`, `VERLOREN`,`GEWONNEN` + `VERLOREN` AS `AANTAL_SETS`
    FROM
    `wedstrijden`
    WHERE
    `GEWONNEN` + `VERLOREN` = 5;
    
    
SELECT 
    `PLAATS`, `NAAM`
FROM
    `spelers`
WHERE
    `PLAATS` = 'Den Haag' OR 'Rijswijk' 

SELECT 
 `GESLACHT`, `NAAM`, `PLAATS`
FROM
    `spelers`
WHERE
    `GESLACHT` = 'v' 
    AND `PLAATS` = 'zoetermeer'; 
    
SELECT 
    *
FROM
    `boetes`
    where 
    `SPELERSNR` = 44 and year(`datum`) =1980
    or month(`datum`) <> 12; 
    
SELECT
`spelersnr`, `naam`, `plaats`, `straat`
FROM
`spelers`    
WHERE 
left(`straat`,1) = 's' and `PLAATS` <> 'Den Haag' 

SELECT
`spelersnr`, `naam`, `jaartoe`
FROM
`spelers`
where
`jaartoe` >= 1982; 

SELECT
`spelersnr`, `naam`, `plaats`
FROM
`spelers`
where 
`GESLACHT` = 'v' and `plaats` <> 'Den Haag' */


    

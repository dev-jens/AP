SELECT
	`SPELERNR`,
    `NAAM`,
    `STRAAT`
FROM 
	`spelers`
WHERE
	`STRAAT` LIKE '%weg';
    
-- 2 
SELECT
	`SPELERNR`,
    `NAAM`,
    `STRAAT`
FROM 
	`SPELERS`
WHERE 
	`STRAAT` LIKE 'h%e%' ;
-- 3
SELECT 
	`SPELERNR`,
    `NAAM`
FROM     
	`SPELERS`
WHERE 
	`NAAM`  NOT LIKE '_i%';
-- 4
SELECT 
	`SPELERSNR`,
    `NAAM`
FROM     
	`SPELERS`
WHERE
	left(`NAAM`,2) LIKE '_e' AND
    right(`NAAM`,2) LIKE 'e_';
	
	
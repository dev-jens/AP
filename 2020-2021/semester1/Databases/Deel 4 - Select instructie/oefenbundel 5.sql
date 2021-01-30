use `gamemania`;
SELECT 
    *
FROM
    `tblConsoles`;
    
SELECT 
    REPLACE(`NAAM`, ' ', '_')
FROM
    `tblUitgevers`;
    
SELECT 
    LCASE(`NAAM`)
FROM
    `tblgamedefinitions`;

SELECT 
    REPLACE(REPLACE(LOWER(`NAAM`), ' ', '_'),
        '-',
        '_') AS GAME
FROM
    `tblgamedefinitions`;

SELECT 
    CONCAT(MONTH(`releasedatum`),
            '-',
            DAY(`releasedatum`),
            '-',
            YEAR(`releasedatum`)) AS releasedate
FROM
    `tblConsoles`;

SELECT 
    `naam`, LENGTH(`naam`) AS lengte
FROM
    `tblgamedefinitions`;

SELECT 
    MAX(`PRIJS`) AS HOOGSTE_PRIJS
FROM
    `tblgames`;
    
SELECT 
    SUM(`PRIJS`) AS MAX_OMZET
FROM
    `tblgames`;	
SELECT 
    `gamedefinitionid`,
    `consoleid`,
    CASE
        WHEN `gametypeid` = 1 THEN 'nieuw'
        ELSE 'ocasie'
    END AS gametype,
    `price`,
    `btw_percentage`
FROM
    `tblgames`;

SELECT 
    CONCAT(`id`,';', 
	`naam`,';' ,
    `uitgever`,';', 
    `releasedatum`,';') as csv
FROM
    `tblgamedefinitions`


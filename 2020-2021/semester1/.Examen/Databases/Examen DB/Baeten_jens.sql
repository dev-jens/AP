-- vraag 1 
USE `gamemania`;
CREATE TABLE IF NOT EXISTS `tblAccesories` (
    `id` SMALLINT UNSIGNED AUTO_INCREMENT,
    `productiecode` CHAR(15) NOT NULL,
    `consoleid` INT,
    `name` VARCHAR(50) NOT NULL,
    `price` DECIMAL(6 , 2 ) NOT NULL,
    `registered_on` DATE NOT NULL,
    `in_stock` TINYINT DEFAULT TRUE,
    PRIMARY KEY (`id`),
    UNIQUE (`productiecode`),
    FOREIGN KEY (`consoleid`)
        REFERENCES `tblconsoles` (`id`)
        ON DELETE RESTRICT
)  AUTO_INCREMENT=10; 

-- vraag 2
USE `tennis`;
SELECT 
    w.`WEDSTRIJDNR`
FROM
    `wedstrijden` w
WHERE
    `GEWONNEN` + `VERLOREN` = 5;
    
-- vraag 3
USE `gamemania`;
SELECT 
    COUNT(*) AS aantal
FROM
    `tblgamedefinitions`
WHERE
    MONTH(`releasedatum`) = 10
        AND `naam` LIKE '%super%';

-- vraag 4
USE `tennis`;
SELECT 
    t.`teamnr`,
    (SELECT 
            `naam`
        FROM
            `spelers` s
        WHERE
            t.`spelersnr` = s.`spelersnr`) AS 'aanvoerder naam',
    (SELECT 
            COUNT(*)
        FROM
            `wedstrijden` w
        WHERE
            t.`teamnr` = w.`teamnr`) AS 'aantal gespeelde wedstrijden'
FROM
    `teams` t
ORDER BY `aantal gespeelde wedstrijden`;

SELECT 
   DISTINCT s.`NAAM`
FROM
    `spelers` s
    INNER JOIN `bestuursleden` b ON s.`spelersnr` = b.`spelersnr`
WHERE
    b.`functie` = 'penningmeester' and b.`spelersnr`= 27;
	
--  vraag 6
use `tennis`;
SELECT 
    s.`spelersnr`,
    s.`naam`,
    count(*),
    (SELECT 
            SUM(b.`bedrag`)
        FROM
            `boetes` b
        WHERE
            b.`spelersnr` = s.`spelersnr`) AS som
FROM
    `spelers` s
    inner JOIN `boetes`b ON s.`spelersnr` = b.`spelersnr` 

	






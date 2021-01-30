use tennis;

SELECT 
    s.`spelersnr`,
    s.`naam`,
    s.`plaats`,
    b.`betalingsnr`,
    b.`bedrag`
FROM
    `boetes` b
        INNER JOIN
    (SELECT 
        `spelersnr`,
            CONCAT(`voorletters`, '. ', `naam`) AS `naam`,
            `plaats`
    FROM
        `spelers`
    WHERE
        `plaats` = 'Den Haag'
            OR `naam` LIKE 'c%') s ON s.`spelersnr` = b.`spelersnr`;
            
SELECT 
    s.`spelersnr`,
    CONCAT(s.`voorletters`, '. ', `naam`),
    s.`plaats`,
    b.`betalingsnr`,
    b.`bedrag`
FROM
    `boetes` b
        INNER JOIN `spelers` s ON s.`spelersnr` = b.`spelersnr`
WHERE
    `plaats` = 'Den Haag'
        OR `naam` LIKE 'c%';
            
            
            
            
            
            
            
            

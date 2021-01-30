USE  `TENNIS`;
-- 1
SELECT 
    `SPELERSNR`,
    `TEAMNR`,
    CASE
        WHEN `GEWONNEN` > `VERLOREN` THEN 'GEWONNEN'
        ELSE 'VERLOREN'
    END AS RESULTAAT
FROM
    `wedstrijden`;
    
-- 2
SELECT 
    `SPELERSNR`,
    CASE
        WHEN `JAARTOE` < 1980 THEN 'OUDEREN'
        WHEN `JAARTOE` >= 1980 AND `JAARTOE` < 1983 THEN 'JONGEREN'
        ELSE 'KINDEREN'
    END AS GROEP
FROM
    `SPELERS`;
    
-- 3
SELECT 
    `SPELERSNR`,
    CASE
        WHEN
            `JAARTOE` < 1980
        THEN
            CASE
                WHEN `BONDSNR` IS NULL THEN 'RECREATIE'
                ELSE 'COMP'
            END
        WHEN `JAARTOE` >= 1980 AND `JAARTOE` < 1983 THEN 'JONGEREN'
        ELSE 'KINDEREN'
    END AS GROEP
FROM
    `SPELERS`
    


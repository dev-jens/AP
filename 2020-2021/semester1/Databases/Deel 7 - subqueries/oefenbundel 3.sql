
-- 3
SELECT 
    b.`BETALINGSNR`, b.`SPELERSNR`
FROM
    `boetes` b
WHERE
    b.`SPELERSNR` = (SELECT 
            t.`SPELERSNR`
        FROM
            `teams` t
        WHERE
            t.`SPELERSNR` = b.`SPELERSNR`)
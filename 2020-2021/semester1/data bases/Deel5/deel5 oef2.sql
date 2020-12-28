/* SELECT
`BETALINGSNR`, `bedrag`
FROM
`boetes`
where
`bedrag` in (50,75,100); 

SELECT 
    *
FROM
    `spelers`
WHERE
    `SPELERSNR` NOT IN (8 , 27, 112); 

SELECT 
`SPELERSNR`, `NAAM`, `STRAAT`
FROM
`SPELERS`
WHERE	
LEFT(`STRAAT`,1) IN ('e','i','s') */

SELECT
`SPELERSNR`, ``

SELECT 
    s.`SPELERSNR`, s.`naam`
FROM
    `spelers` s
WHERE
    s.`SPELERSNR` IN (SELECT 
            b.`SPELERSNR`
        FROM
            `boetes` b
        WHERE
            b.`bedrag` <= 50);
                        
-- 2 
SELECT 
	B.`BETALINGSNR`,
    B.`BEDRAG`
FROM 
	`BOETES` B
WHERE 
	B.`BEDRAG` IN 
    (100,
    B.`BEDRAG` = 5* B.`BETALINGSNR`, `BETALINGSNR` = 2 ) ;
    
SELECT 
	B.`BETALINGSNR`,
    B.`BEDRAG`
FROM 
	`BOETES` B
WHERE 
	B.`BEDRAG` IN 
    (
		100,
		B.`BEDRAG` = 5* B.`BETALINGSNR`, 
		( select 
			b2.`bedrag`
		from 
			`boetes`b2
		where 
			`betalingsnr` = 2)
	); 


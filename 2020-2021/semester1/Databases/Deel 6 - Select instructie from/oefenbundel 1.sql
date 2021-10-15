SELECT 
    b.`betalingsnr`, b.`bedrag`, s.`naam`
FROM
    `boetes` b,
    `spelers` s
WHERE
    b.`spelersnr` = s.`spelersnr`;
    
-- 2 
SELECT 
    s.`spelersnr`, s.`naam`, w.*
FROM
    `SPELERS` s,
    `wedstrijden` w
WHERE
    w.`spelersnr` = s.`spelersnr`;
    
-- 3
SELECT 
	b.`betalingsnr`,
    b.`bedrag`,
    s.`naam`,
    s.`plaats`
FROM 
	`boetes`b,
    `spelers`s
WHERE
	s.`spelersnr` = b.`spelersnr`
    AND `plaats` = 'Den Haag';
    
-- 4
SELECT
	w.`wedstrijdnr`,
    s.`naam`,
    t.`divisie`,
    case
		when `gewonnen` > `verloren` then 'gewonnen'
        else 'verloren'
    end as resultaat
FROM
	`wedstrijden` w,
    `spelers`s,
    `teams` t
WHERE
 s.`spelersnr` = w.`SPELERSNR`
 and w.`teamnr` = t.`teamnr`
 and `wedstrijdnr` > 10;


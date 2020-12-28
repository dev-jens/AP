/*SELECT 
    b.`betalingsnr`, b.`bedrag`, s.`naam`
FROM
    `boetes` b,
    `spelers` s
where 
	s.`SPELERSNR`= b.`SPELERSNR`;
    
SELECT
	s.`spelersnr`,
    s.`naam`,
    w.*
FROM
	`spelers`s,
    `wedstrijden` w
where
s.`spelersnr` = w.`spelersnr` ; 

SELECT 
    b.`betalingsnr`, b.`bedrag`, s.`naam`, s.`plaats`
FROM
    `boetes` b,
    `spelers` s
WHERE
    s.`plaats` = 'Den Haag'
        AND s.`SPELERSNR` = b.`SPELERSNR`; */
        
SELECT
w.`wedstrijdnr`,
s.`naam`,
t.`divisie`,
CASE 
		WHEN (w.`GEWONNEN` - w.`VERLOREN`) > 0 then 'gewonnen'
        WHEN (W.`GEWONNEN` - W.`VERLOREN`) < 0 then 'verloren'
        ELSE 'gelijk'
	end as `resultaat`
FROM
`wedstrijden`w,
`spelers`s,
`teams` t
where
w.`SPELERSNR`= s.`SPELERSNR` and w.`TEAMNR` = t.`TEAMNR`
and `wedstrijdnr` <= 10; 




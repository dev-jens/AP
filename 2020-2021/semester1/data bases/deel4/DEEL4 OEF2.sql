 SELECT 
    `SPELERSNR`,
    `TEAMNR`,
    CASE 
		WHEN (`GEWONNEN` - `VERLOREN`) > 0 then 'gewonnen'
        WHEN (`GEWONNEN` - `VERLOREN`) < 0 then 'verloren'
        ELSE 'gelijk'
	end as `resultaat`
FROM
    `wedstrijden`
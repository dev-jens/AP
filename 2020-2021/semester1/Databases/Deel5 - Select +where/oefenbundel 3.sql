select 
	`betalingsnr`
from 
	`boetes`
where
	`bedrag` BETWEEN 50 and 100;
    
-- 2
select 
	`betalingsnr`
from 
	`boetes`
where
	`bedrag` NOT BETWEEN 50 and 100;

-- 3 
SELECT
	*
FROM 
	`spelers`
where
	`wedstrijdnr` BETWEEN 5 and 10 and
    `spelersnr` in (8,27);
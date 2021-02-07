select 
	`spelernr`
from 
	`spelers`
where 
	`bondsnr` is null;

select 
	count(*) as active_bestuursleden
from 
	`bestuursleden`
where
	`EIND_DATUM` is not null
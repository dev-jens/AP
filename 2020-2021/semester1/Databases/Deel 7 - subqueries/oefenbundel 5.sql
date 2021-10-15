SELECT 
	s.`SPELERSNR`
from
	`spelers`s
where
	s.`SPELERSNR` not in 
    ( select 
		w.`spelersnr`
	  from
			`wedstrijden` w
		WHERE
			`gewonnen` =3
    );
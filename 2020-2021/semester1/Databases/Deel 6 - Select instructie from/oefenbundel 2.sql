SELECT
	s.*,
    b.`functie`,
    case
		when `eind_datum` is null then '  actief'
        when `EIND_DATUM` is not null then 'niet actief'
	end as actief
FROM 
	`SPELERS` s
     inner join `bestuursleden` b on s.`spelernr` = b.`spelernr`
WHERE
 `functie` = 'voorzitter' or `functie` = 'penningmeester';
 
SELECT
	s.`SPELERSNR`,
    s.`naam`,
    concat(w.`gewonnen`, ' - ', w.`verloren`) as uistlag
FROM 
	`wedstrijden` w 
    inner join `spelers`s on s.`spelersnr` = w.`spelersnr`
    inner join `teams`t ON w.`spelernr` = t.`spelernr`;
    

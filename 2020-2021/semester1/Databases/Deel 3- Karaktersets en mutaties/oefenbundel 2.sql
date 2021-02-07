use tennis2;

-- 1
RENAME TABLE `bestuursleden` TO `tblbestuursleden`;
RENAME TABLE `boetes` TO `tblboetes`;
RENAME TABLE `spelers` TO `tblspelers`;
RENAME TABLE `teams` TO `tblteams`;
RENAME TABLE `wedstrijden` TO `tblwedstrijden`;

ALTER TABLE `tblboetes` 
ADD `REDEN` varchar(255);

ALTER TABLE `tblspelers` ADD 
(
	`voornaam` varchar(50)
);
ALTER TABLE `tblboetes` ADD 
`paymentdate` DATE AFTER `BEDRAG` ;

ALTER TABLE `tblspelers` 
DROP `VOORLETTERS`;

ALTER TABLE `tblspelers`
CHANGE `NAAM` `NAAM` varchar(50) not null;

ALTER TABLE `TBLSPELERS` ADD CONSTRAINT
UNIQUE(`naam`,`straat`,`huisnr`,`postcode`);






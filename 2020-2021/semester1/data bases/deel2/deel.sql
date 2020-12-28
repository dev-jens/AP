/*RENAME TABLE bestuursleden TO tblbestuursleden;
RENAME TABLE boetes TO tblboetes;
RENAME TABLE spelers TO tblspelers;
RENAME TABLE teams TO tblteams;
RENAME TABLE wedstrijden TO tblwedstrijden; 

ALTER TABLE `tblboetes` ADD 
(
`REDEN` varchar(255)
);

ALTER TABLE `tblspelers` ADD 
(
`VOORNAAM` varchar(50)
);

ALTER TABLE `tblboetes` ADD `PAYMENTDATE` date after `BEDRAG` 

ALTER TABLE `tblspelers`
DROP `VOORLETTERS`;

ALTER TABLE `tblboetes`
CHANGE `PAYMENTDATE`  `BETALINGSDATUM` DATE; 

ALTER TABLE `tblspelers`
CHANGE `NAAM`  `NAAM` VARCHAR(50) NOT NULL; */

 -- "ALTER TABLE `tblspelers` ADD CONSTRAINT UNIQUE (`NAAM`,`STRAAT`,`HUISNR`,`POSTCODE`);



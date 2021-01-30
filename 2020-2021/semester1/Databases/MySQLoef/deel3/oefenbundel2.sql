--2
RENAME TABLE `boetes` TO `tblBoetes`;
--3
ALTER TABLE `tblBoetes` ADD (
    `reden` varchar(255)
);
--4
ALTER TABLE `tblBoetes` ADD (
    `VOORNAAM` varchar(50)
);
--5
ALTER TABLE `tblSpelers` ADD(
    `PAYMENTDATE` DATE AFTER `BEDRAG`
);
--6
ALTER TABLE `tblSpelers` DROP(
    `VOORLETTERS`
);
--7
ALTER TABLE `tblBoetes` CHANGE(
    `PAYMENTDATE`  `BETALINGSDATUM` DATE
);
--8
ALTER TABLE `tblSpelers` CHANGE (
    `NAAM` `NAAM` varchar(50) not null
);
--9
ALTER TABLE `tblSpelers` ADD CONSTRAINT (
    unique(`naam`,`huisnr`,`straat`,`postcode`)

);

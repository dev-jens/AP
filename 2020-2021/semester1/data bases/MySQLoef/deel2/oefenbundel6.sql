use `ap`
--1
DROP TABLE  `AP`.`AFDELINGEN`;
--2
CREATE TABLE `tblOpleidingen`(

    `Code` VARCHAR(10) PRIMARY KEY,
    `Omschrijving` MEDIUMTEXT,
    `Duur`  TINYINT UNSIGNED
);
CREATE TABLE `tblAfdelingen`(
    `NR` SMALLINT UNSIGNED PRIMARY KEY AUTO_INCREMENT,
    `NAAM` VARCHAR(100),
    `Replicatiecode` CHAR(32)

)AUTO_INCREMENT = 10;
CREATE TABLE `tblmedewerkers`(
    `NR` MEDIUMINT UNSIGNED PRIMARY KEY AUTO_INCREMENT,
    `NAAM` VARCHAR(100),
    `ADRES` VARCHAR(135),
    `AFDELINGNR` SMALLINT
    FOREIGN KEY (`AFDELINGNR`)
    REFERENCES `tblAfdelingen`(`NR`)
)AUTO_INCREMENT = 1;
CREATE TABLE `tblGevolgdeOpleiding`(
    `mederwerkerNR` MEDIUMINT,
    `OpleidingsCode` VARCHAR(10),
    `Datum` DATE,
    `Voltooid` BIGINT UNSIGNED,
    FOREIGN KEY (`MedewerkerNR`)
    REFERENCES `tblMedewerkers`(`NR`),
    FOREIGN KEY (`OpleidingsCode`)
    REFERENCES `tblOpleidingen`(`Code`)
);
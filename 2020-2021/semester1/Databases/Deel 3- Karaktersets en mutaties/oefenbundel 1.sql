-- 1 
Create database if not EXISTS `learning` default charset utf8mb4;
use `learning`;

CREATE TABLE `tblLanguages`
(
	`ID` MEDIUMINT UNSIGNED PRIMARY KEY AUTO_INCREMENT,
    `NAME` VARCHAR(20) not null UNIQUE
)default charset latin1;

CREATE TABLE `tblCourseDefinitions`
(
	`ID` MEDIUMINT UNSIGNED,
    `LanguageId` VARCHAR(20) not null,
    `name` VARCHAR(100),
    `ReplicationKey` char(36) charset Latin1 not null,
    PRIMARY KEY(`ID`),
    UNIQUE(`LanguageId`, `name`, `ReplicationKey`),
    FOREIGN KEY (`LanguageId`) REFERENCES `tblLanguages`(`ID`)

);


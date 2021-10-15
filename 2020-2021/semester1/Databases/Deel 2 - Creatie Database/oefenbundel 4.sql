-- 1
CREATE DATABASE IF NOT EXISTS `planes`;
USE `planes`;
-- 2
CREATE TABLE `tblManufacturers` (
    `Id` SMALLINT UNSIGNED PRIMARY KEY AUTO_INCREMENT,
    `Name` VARCHAR(70) UNIQUE
)  AUTO_INCREMENT=101;

CREATE TABLE `tblPlaneDefinitions` (
    `Id` MEDIUMINT UNSIGNED PRIMARY KEY AUTO_INCREMENT,
    `ManufacturesId` SMALLINT UNSIGNED UNIQUE not null,
    `Name` VARCHAR(100) NOT NULL unique,
    `DesignDate` DATE not null unique,
    `IsMilitary` TINYINT UNSIGNED,
    `NumberOfEngines` tinyint,
    `weight` decimal(5,2),
    FOREIGN KEY (`ManufacturesId`)
        REFERENCES `tblManufacturers` (`Id`)
	ON DELETE RESTRICT
    
)AUTO_INCREMENT =1;
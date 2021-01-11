CREATE DATABASE `tblManufactures`
USE `tblManufacturs`;
CREATE TABLE `tblManufacturs`(
    `ID` SMALLINT UNSIGNED  PRIMARY KEY
    `Name` VARCHAR(70) UNIQUE, --(NOT NULL)
    ``
)AUTO_INCREMENT = 101;

CREATE TABLE `tblPlanesDefinitions`(
    `ID` MEDIUMINT UNSIGNED PRIMARY KEY AUTO_INCREMENT,
    `ManufacturerId` SMALLINT UNSIGNED NOT NULL UNIQUE ,
    `Name` VARCHAR(100) NOT NULL UNIQUE,
    `DesignDate` DATE NOT NULL UNIQUE,
    `IsMilitary` tinyint UNSIGNED,
    `NumberOfEnignes` tinyint UNSIGNED,
    `weight` decimal(5,2),
    FOREIGN KEY (`ManufacturesId`)
    REFERENCES `fabrukant`(`id`),
    ON DELETE RESTRICT

)AUTO_INCREMENT =1;
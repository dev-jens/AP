--1 
CREATE DATABASE `AP`;
USE `AP`;

CREATE TABLE `AP`.`AFDELING` (
    `AFDNR` CHAR(5) PRIMARY KEY,
    `BUFGET` DECIMAL (8,2) NOT NULL,
    `LOCATIE` VARCHAR(30),
    `ISACTIEF` TINYINT UNSIGNED DEFAULT FALSE,
    `GEMPUNTEN` DECIMAL(5,2) 

);

--2
INSERT INTO `AP`.`AFDELING` VALUES ('12345',2000.25, 'Campus Ellermanstraat',FALSE, 12.43);

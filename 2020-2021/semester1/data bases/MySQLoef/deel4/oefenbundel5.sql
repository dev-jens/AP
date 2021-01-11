--1
SELECT
    *
FROM    
    tblconsoles;
 --2
SELECT
    REPLACE(`naam`, ' ', '_') as uitgevers
FROM
    tbluitgevers
--3
SELECT
    LCASE(`naam`) as uitgevers
FROM
    tblgamedefinitions

--4
SELECT
    REPLACE(
        LCASE(`naam`),' ' or '-', '_') as game
 FROM
    tblconsoles

 --5 
 SELECT
     naam ,
     CONCAT(
        MONTH(`releasedatum`),'-',
        DAY(`releasedatum`),'-',
        YEAR(`releasedatum`)
        ) AS releasedatum
FROM 
    tblgamedefinitions

--6
SELECT
    naam,
    LENGHT(`naam`) as lengte
FROM    
    tblgamedefinitions

--7
SELECT
    MAX(`price`) as hoogste_prijs
FROM
    tblgamedefinitions
--8
SELECT
    SUM(`price`) as MAX_omzet
FROM
    tblgamedefinitions

--9
SELECT

FROM
    `tblgames`
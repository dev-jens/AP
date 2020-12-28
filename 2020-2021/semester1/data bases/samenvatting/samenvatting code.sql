Deel 2 CREATE DATABASE (

aanmaken, verwijderen van database, table (
-- create a database 
create database `ap`

-- create database als het nog niet bestaat
create database IF NOT EXISTS `ap`

-- verwijderen database
drop database `ap`

-- verwijder database indien deze bestaat
drop  database if  exists `ap`

/* create table, datatype(int, var, varchar,.. ) verplicht. ovirige niet ,table start met tbl */

create table (`ap`.)`tblCodeMonkey`(
`id` int unsigned not null primary key auto_increment,
`firstname` varchar(50) not null,
`lastname` varchar(75) not null);
)

soorten datatype (
-- INTEGERS	

INT 				--> POSITIVE ALS NEGATIVE GETALLEN -2 MILJARD TOT 2 MILJARD 
INT UNSIGNED 		--> GEEN TEKENBIT, ENKEL POSITIVE GETALLEN 0 TOT 4.2 MILJARD

TINYINT 			--> -128 TOT 127
TINYINT UNSIGNED	--> 0 TOT 255

SMALLINT  			-->  -32.768 TOT 32.767
SMALLINT UNSIGNED 	--> 0 TOT 65 535

MEDIUMINT 			--> -8 388 608 TOT 8 388 607
MEDIUMINT UNSIGNED 	--> 0 TOT 16.7 MIL

BIGINT 				--> HEEL HOOG
BIGINT UNSIGNED  	--> NOG HOGER 

CREATE TABLE `tblCodeMonkey` (`id` int unsigned);

--  DECIMAL

DECIMAL(6,4) 		--> 6 CIJFER IN TOTAA, WAARVAN 4 NA DE KOMMA KOMEN BV 12,3456

CREATE TABLE `tblAcounts` (`Amount` DECIMAL(6.4)).
INSERT INTO `tblAcounts` VALUES (12.4) -- 12.4000

-- CHAR AND VARCHAR 

CREATE TABLE `tblCodeMonkey` (`barcode` char(13)); 	-- char is voor een vaste waarde(isbn, barcode,banknummer) zo gaan er geen bits veloren.

CREATE TABLE `tblBooks`(`Title` VARCHAR(50)); 		-- varchar is voor een niet vaste waarde(titles, namen,..) deze gebruikt minder bytes. enkeml als dezehelemaal vol is gebruikt die 5 bytes 


-- TEXT	

TINYTEXT 	-- 255B (255 karakters)
TEXT		-- 64KB (65 535 karakters)
MEDIUMTEXT	-- 16MB
LONGTEXT	-- 4GB

CREATE TABLE `tblBooks`(`revieuw` TEXT)
CREATE TABLE `tblCources``(`ShortText` TINYTEXT)


-- temporial

DATE 		--	enkel datum,  bereik van 1000-01-01 tot 9999-12-31
DATETIME	--	datum en tijd, bereik van 1970-01-01 00:00:001 tot 9999-12-31 23:59:59	
TIMESTAMP	--	datum en tijd, bereik van 1970-01-01 00:00:001 tot 2038-01-19 03:14:07
TIME		--	tijd en verlopen tijd(elapsed time), bereik van -838:59:59 tot 838:59:59

CREATE TABLE `tblPersons`(`DateOfBirth` DATETIME);
CREATE TABLE `tblGameStats`(`Duration` TIME);
CREATE TABLE `tblProducts`(`AvailableUntil` DATE);

-- boolean

CREATE TABLE `tblBooks`(`Available` TINYINT);	--  0 of constante FALSE = Onwaar , Niet(!) 0 of constante TRUE = Waar

-- UID (GUID)
CREATE TABLE `tblCourse`(`ReplicationKey` CHAR(32));	--	32 karakters (zonder -), 4A5E05D9-9AF74C50B41C93EF9995DE64 

CREATE TABLE `tblCourse`(`ReplicationKey` CHAR(36));	--	36 karakters (met -), 	 4A5E05D9-9AF7-4C50-B41C-93EF9995DE64
)

integerregels (

-- (NOT) NULL

CREATE TABLE `tblMemberships`(`EndDate` DATE NULL); 			--Expliciet instellen dat NULL toegelaten wordt voor deze kolom
CREATE TABLE `tblMemberships`(`EndDate` DATE);					--Impliciet instellen dat NULL toegelaten wordt voor deze kolom
CREATE TABLE `tblFines`(`Amount` DECIMAL(7,2) NOT NULL); 		--Expliciet instellen dat NULL NIET toegelaten wordt voor deze kolom

-- DEFAULT

CREATE TABLE `tblTasks`(`Status` VARCHAR(15) DEFAULT 'To do'); 	--Standaardwaarde invullen in geval bij INSERT geen waarde werd voorzien 

-- PRIMARY KEY

CREATE TABLE `tblTasks`( 										--Uniek identificeren van een record in een tabel (moet een unieke waarde bevatten EN mag geen null bevatten
`Id` INT UNSIGNED PRIMARY KEY
,…);

CREATE TABLE `tblTasks`( 
`Id` INT UNSIGNED,
PRIMARY KEY(`Id`)
);	

CREATE TABLE `tblGamesPlayed`( 									--Primary key bestaande uit meerdere kolommen
`GameId` INT UNSIGNED, 
`PlayerId` INT UNSIGNED, 
PRIMARY KEY(`GameId`,`PlayerId`)
); 


-- PRIMARY KEY  MET AUTO_INCREMENT 

CREATE TABLE `tblTasks`(										--Startwaarde wordt impliciet ingesteld op 1  
`Id` INT UNSIGNED PRIMARY KEY AUTO_INCREMENT
);

CREATE TABLE `tblTasks`(										--Startwaarde wordt expliciet ingesteld op 10
Id` INT UNSIGNED PRIMARY KEY AUTO_INCREMENT
)AUTO_INCREMENT=10;

-- UNIQUE KEY

CREATE TABLE `tblPlayers`(
`Id` INT UNSIGNED PRIMARY KEY,
`FederationNumber` VARCHAR(10) UNIQUE
);																--Logische primaire sleutel implementeren, Afdwingen dat geen dubbele waarden voor deze kolom(men) mogen bestaan

CREATE TABLE `tblPlayers`(
`Id` INT UNSIGNED PRIMARY KEY,
`FederationNumber` VARCHAR(10),
UNIQUE(`FederationNumber`)
);

-- FOREIGN KEY

CREATE TABLE `tblSales`(
`Id` INT UNSIGNED PRIMARY KEY,	
`ProductId` INT UNSIGNED,
…,
FOREIGN KEY (`ProductId`)
REFERENCES `tblProducts`(`Id`)
);																-- Relatie definiëren tussen 2 tabellen, Gegevensintegriteit garanderen (geen verwijzingen naar onbestaande records)

-- REFERENTIAL ACTION

--CASCADE voor UPDATE (aanpassing van alle refererende records)
-- Pas waarde aan in parent tabel
-- Zoek waarde op in refererende tabel
-- Gevonden? Pas refererende waarde aan

--RESTRICT voor UPDATE (aanpassing enkel als er geen refererende records zijn)
-- Zoek waarde op in refererende tabel
-- Gevonden? Blokkeer UPDATE en toon melding
-- Niet gevonden? Pas waarde aan in parent tabel

CREATE TABLE `tblSales`(
`Id` INT UNSIGNED PRIMARY KEY,	
`ProductId` INT UNSIGNED,
…,	
FOREIGN KEY (`ProductId`)
REFERENCES `tblProducts`(`Id`)
ON UPDATE CASCADE 
ON DELETE CASCADE);
)
)

Deel 3 Karaktersets en mutaties (

karakterset(
CREATE DATABASE `AP` DEFAULT CHARSET Latin1;
CREATE DATABASE `AP` DEFAULT CHARACTER SET utf8mb4;
CREATE DATABASE `AP` CHARSET utf8mb4;
CREATE DATABASE `AP` CHARACTER SET utf8mb4;


CREATE TABLE `tblStudent`(
`Id` INT UNSIGNED PRIMARY KEY,
`FirstName` VARCHAR(30),
`LastName` VARCHAR(40),
`CardBarcode` CHAR(13) CHARSET Latin1) --> instellen op kollomniveau
DEFAULT CHARSET utf8mb4 --> instellen op tabelniveau
)

Collation (
-- Bepalen welke regelset gebruikt wordt om alfanumerieke gegevens te sorteren en vergelijken

-- ci = case insensitive  vergelijking niet hoofdlettergevoelig --> ‘A’ = ‘a’
-- bin = case sensitive   vergelijking hoofdlettergevoelig --> ‘A’ <> ‘a’

CREATE TABLE `tblStudent`(
`Id` INT UNSIGNED PRIMARY KEY, 
`FirstName` VARCHAR(30),
`LastName` VARCHAR(40),
`CardBarcode` CHAR(13) CHARSET Latin1 COLLATE latin1_German1_ci) 
DEFAULT CHARSET utf8mb4 COLLATE utf8mb4_bin;
)

mutaties(

-- tabel naam wijzigen

rename table `studenten` to `tblDepresieveLevensvorm`
rename table ap.`studenten to ap.`tblStudent`

-- tabbelen kolommen toevoegen ,verwijderen 
-- door ADD, DROP, ALTER COLUMN

ALTER TABLE `Customers` 					-- voeg een kolom toe door middel van ADD 
ADD	`Email` varchar(255);	

ALTER TABLE `Customers` 					-- verwijder een kollom door DROP
DROP `Email`;	

ALTER TABLE `Customers` 					-- verander eigenschap van een kollom door CHANGE
CHANGE `Email` `email` varchar(242);					

-- gegevens toevoegen in een tabel

INSERT INTO `tblPlatforms`(`name`) VALUES('PS5');
INSERT INTO `gamemania`.`tblPlatforms`(`name`) VALUES('PS5');

-- meerdere keer kolommen in 1keer 

INSERT INTO `tblPlatfroms`(`id`,`name`) VALUES ('1','Playstation4')  

INSERT INTO `tblPlatfroms` VALUES ('1','Playstation4')

INSERT INTO `tblPlatforms` VALUES (1,'PS5'),(2,'Xbox One'),(3,'PC');

-- Gegevens wijzigen (toevoegen)

UPDATE `tblPlatforms` SET `name` = 'PS6' WHERE `id` = 1;

-- Gegevens wijzigen (verwijder)
INSERT INTO `tblPlatforms` VALUES (1,'PS5'),(2,'Xbox One'),(3,'PC');
)
)

deel 4 SELECT instructie (

-- expresie

SELECT
	`id`,
	UCASE(`name`),					-- zet tekst in hoofdletters	
	`prijs` * 0.05,
	'korting' AS status				-- 
FROM
	`tblConsoles`
WHERE
	`fabrikant` = 'sony';

-- QUERY

SELECT
	`ConsoleId`,
	COUNT(`ConsoleId`) AS `NumberOfGames`       -- het aantal id dat niet null zijn worden getoont in de tabel numberofgames 
FROM
	`tblGames`									-- tabel waar informatie wordt uitgehaald
WHERE  
	`Genre` = 'Sports'							-- waar het genre van het spel sport is 
GROUP BY 
	`ConsoleId` HAVING COUNT(*) > 1 			-- froup by welke kolom komt eerst  
ORDER BY	 
	`NumberOfGames` DESC;


-- CASE 

SELECT
	`name`,
		CASE
		WHEN year(`releasedatum`) >= 200 THEN 'Nieuwste' 
		WHEN YEAR(`releasedatum`) > 2010 THEN 'Oudste'
		ELSE
	END AS `status`
FROM
	`tblCodeMonkey`


-- SCALAIRE FUNCTIES 
UCASE('database') 								-- 'DATABASE' 
LCASE('DATABASE') 								-- 'database' 
LTRIM('  VOORLETTERS') 							-- 'VOORLETTERS'
RTRIM('VOORLETTERS  ') 							-- 'VOORLETTERS'
LEFT('VOORLETTERS',1) 							-- 'V'
RIGHT('VOORLETTERS',1)							-- 'S'
LENGTH('VOORLETTERS') 							-- '11'
CONCAT('Apu','.','Nahasapeemapetilon') 			-- 'Apu.Nahasapeemapetilon'
REPLACE('VUURLETTERS','U','O')					-- 'VOORLETTERS'
SUBSTRING('VOORLETTERS',4,2) 					-- 'RL' SUBSTRING('string', start, lenght)

YEAR(`DATUM`) 									-- jaartal van de datum 2020-10-12
MONTH(`DATUM`) 									-- maand van de datum 10
DAY(`DATUM`) 									-- dag van de datum 12
DAYNAME('2020-10-12') 							-- 'Monday' dag naam
MONTHNAME('2020-10-12') 						-- 'October' maand in letters 
DAYOFYEAR('2020-10-12')						 	-- 286  hoeveelste dag van het jaar 
DATEDIFF ('2020-10-12','2020-10-02') 			-- 10	dagen verschil

MIN(`PRIJS`) 									-- haalt laagste prijs op uit kolom PRIJS
MAX(`PRIJS`) 									-- haalt hoogste prijs op uit kolom PRIJS
AVG(`PRIJS`) 									-- haalt gemiddelde prijs op uit kolom PRIJS
SUM(`PRIJS`) 									-- maakt de som van alle prijzen uit kolom PRIJS
COUNT(`PRIJS`) 									-- telt het aantal rijen, in principe speelt de kolom hier geen rol
)

deel 5 SELECT operators (

-- alle operatoren die je kan gebruiken bij WHERE:

-- 	=  	-gelijk aan 									
-- > <  - groter dan, kleiner dan
-- <> 	- niet gelijk aan 
SELECT
	* 
FROM
	`tblPlatforms`            					-- selecteer (SELECT) alles  van (FROM) de tabbel op opvoorwaarde van (WHERE) dat de naam ps4 is
WHERE 
	`name` =  'PS4';


SELECT
	*
FROM
	`tblPlatfroms`
WHERE
	`name` = 'ps4'
	or `name` = 'ps5'


-- de IN operator zorgt er voor dat je de OR niet moet spammen 
SELECT
	*
FROM
	`tblPlatforms`
WHERE
	`id` (NOT)IN (1,5,6,8,9);				--Alle records uit tabel tblGameDefinitions, Waarvan de waarde van het veld `id` (NIET) voorkomt in de gegeven expressielijst


-- BETWEEN Opperator

SELECT
	* 
FROM
	`tblGameDefinitions`
WHERE 
	`id` BETWEEN 1 AND 10;					-- 	tussen deze waarden tonen 

SELECT
	* 
FROM
	`tblPlatforms`
WHERE 
	YEAR(`release`) BETWEEN 2010 AND 2020;	-- tussen deze jaren tonen

--LIKE Opperator
-- Beginnen met een letter is letter + %  bv s%
-- eindigen met een letter is % + letter  bv %t
-- HOOFDLETTER GEVOELIG !!

SELECT
	*										-- haalt alle platformen op waar de waarde van kolom uigever :
FROM										-- BEGINT met een S, 
	`tblPlatforms`							--Gevolgd door >= 0 willekeurige karakters
WHERE
	`uitgever` LIKE 'S%'					
											

SELECT
	* 										-- Haalt alle platformen op waarvan de waarde van kolom uitgever:
FROM										-- EINDIGT op een t
	`tblPlatforms`							-- Voorafgegaan door >= 0 willekeurige karakters
WHERE 
	`Uitgever` LIKE '%t';


SELECT
	* 										-- Haalt alle platformen op waarvan de waarde van kolom Naam:
FROM										-- Begint met ‘PS‘
	`tblPlatforms`							-- En eindigt met 1 willekeurig karakter
WHERE 										-- Exact 4 karakters lang is
	`Naam` LIKE 'PS _';



-- IS NULL operator

SELECT										-- Haalt alle platformen op waarvan de waarde van kolom `Eindeproductie` NULL (onbekend) is
	*
FROM
	`tblPlatforms`
WHERE
	`Eindeproductie` IS NULL				

	
SELECT										-- Haalt alle platformen op waarvan de waarde van kolom `Eindeproductie` niet NULL (gekend) is
	* 
FROM
	`tblPlatforms`
WHERE 
	`Eindeproductie` IS NOT NULL;
)

deel 6 TABLE alias 7 gram van de sterkste hash(


SELECT
	p.`name` 				-- in de FROM geef je de tabel  naam p  zodat ja deze kan gaa gebruiken in name (zo kan je met meerder tabllen tegelijk beginne werken)
FROM
	`tblPlatforms` p

-- meerdere brontabbelen

SELECT 
	gd.`Naam`,	
	u.`Naam`
FROM
	`tblGameDefinitions` gd,
	`tblUitgevers` u;


-- impliciete join 


SELECT 
	gd.`Naam`,
	u.`Naam`
FROM 
	`tblGameDefinitions` gd,
	`tblUitgevers` u
WHERE
	gd.`uitgever` = u.`id`;

-- Expliciet

--Join syntax zorgt voor duidelijkere query’s door scheiding van
--Join criteria
--Filter criteria
--Join eerst de tabellen met de minste inhoud voor performantie

-- inner join

SELECT 
	gd.`Naam`,
	u.`Naam`
FROM 
	`tblGameDefinitions` gd 
	INNER JOIN `tblUitgevers` u ON gd.`Uitgever` = u.`Id`
	INNER JOIN `tblConsoles` c ON gd.`ConsoleId` = c.`Id`;

-- LEFT JOIN 	

SELECT 
	gd.`Naam`,
	u.`Naam`
FROM 
	`tblUitgevers` u
	LEFT JOIN `tblGameDefinitions` gd ON u.`Id` = gd.`Uitgever`;
	
)

deel 7 (
)

deel8 (

SELECT 
	DISTINCT `naam`, `console`   --> distinct filter alle dubbele waarden er uit 
from
	`tblGameDefinitions`

select 
	`naam`
from
	`spelers`					--> asc is staandaard is oplopend is van klein naar groot, desc is van groot naar klein
order by						--> met data is het asc van oud naar recetn en desc van recent naar oud 
month(`geb_datum`),`naam`DESC 	


SELECT												
	*
from
	`tblUitgevers`
order by
	`naam`
limit 10	--> toon eerste 10 uitgevers 

SELECT
	*
from
	`tblUitgevers`
order by
	`naam`
limit 20,10	--> start aan rij 20 en laat dan 10 rijen zien 

)















































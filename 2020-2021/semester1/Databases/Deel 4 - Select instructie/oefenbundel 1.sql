use `tennis`;
-- 1
SELECT
	`BETALINGSNR`,
    `BEDRAG`
FROM
	`BOETES`;
-- 2
SELECT
	`SPELERSNR`,
    `TEAMNR`,
    `GEWONNEN`-`VERLOREN`
from
	`wedstrijden`;
-- 3
SELECT
	`SPELERSNR`,
    `TEAMNR`,
    `GEWONNEN`-`VERLOREN` as resultaat
from
	`wedstrijden`;


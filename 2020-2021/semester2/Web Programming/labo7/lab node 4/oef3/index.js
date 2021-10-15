
const readlineSync = require('readline-sync');
const user = require("./user");
const game = require("./game");
const scoreboard = require("./scorebord");


let speler = new user();
speler.voornaam = readlineSync.question("wat is je voornaam:  ");
speler.naam = readlineSync.question("wat is je achternaam: ")

const getal = readlineSync.question("getal waar je de som voort wilt oplossen: ")
const aantalSommen = readlineSync.question("hoeveel sommen wil je oplossen: ")

let spel = new game(aantalSommen,getal);
spel.setup();
spel.play();
spel.check();

let spelerPoints = new scoreboard(speler,spel.score, aantalSommen);
spelerPoints.Print(); 
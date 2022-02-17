// Static Types
// Declareer 3 variabelen van een verschillend type op de expliciete manier
var getal1;
var IsBoolean;
var text;
// Declareer 2 variabelen expliciet en ken de som toe aan een derde impliciete variabele
var getal = 5;
var getal2 = 4;
var som = getal + getal2;
console.log(som);
// Declareer een array van getallen
var arr = [1, 3, 5, 6, 67, 4, 345];
// Declareer een array van een ‘enum’ type van enkele kleuren
var kleuren;
(function (kleuren) {
    kleuren[kleuren["Rood"] = 0] = "Rood";
    kleuren[kleuren["Groen"] = 1] = "Groen";
    kleuren[kleuren["Blauw"] = 2] = "Blauw";
})(kleuren || (kleuren = {}));
;
console.log(kleuren.Rood);
// Declareer een array die zowel getallen als boolean types mag bevatten
var arr2 = [1, true, 5, false];
// Declareer een tuple van 3 met een getal, tekst en boolean
var tuple;
// Declareer een variabele van type getal , die ook ‘null’ mag worden toegekend.
var get = null;
console.log(get);
// Gebruik de compiler optie: strictNullChecks en test de werking ervan.

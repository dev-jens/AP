// Maak een functie die
// Het kwadraat van een getal berekend.
function kwadraat(getal) {
    return Math.pow(getal, 2);
}
// arrow function
var kwad = function (get) { return Math.pow(get, 2); };
// een tekst: string en een count: number verwacht
function CreateArr(text, count) {
    var arrayString = [];
    for (var i = 0; i < count; i++) {
        arrayString[i] = text;
    }
    return arrayString;
}
// een string[ ] teruggeeft, met lengte count en inhoud tekst 
// Maak een “anonymous” functie die
// een tekst : string verwacht
// En optioneel een separator : string met default waarde = “-” 
// Die een string[ ] teruggeeft waarbij de text werd opgesplitst adhv. de separator
// Maak een functie om het product te maken van een onbekend aantal parameters
// Schrijf deze bovenstaande functies ook volgens de “fat arrow” syntax.

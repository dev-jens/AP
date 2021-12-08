
// eenvoudige static type variablen
let tekst: string = "";
var vlag: boolean;
var getal: number = 1, getal2: number = 2;
var som = getal + getal2;

//Array
var lijst: number[] = [];
lijst[0] = 23;
lijst[1] = 11;
var lijst2 = ["A", "B", "D"];
var lijst3 = ["A", 5, "C"];
lijst3[3] = 4;

//Enum (is eigenlijk een number type)
enum Color { Red = 3, Green = 2, Blue = 25};
var c: Color = Color.Blue;
//Array van colors
var colors: Color[] = [];
colors.push(Color.Blue);
colors.push(Color.Red);
colors.push(Color.Blue);
console.log(colors.length);

//Tuple
var tup1: [number, string, boolean];
tup1 = [5, "HI", true];
console.log(tup1[2]);

//Dit is enkel nodig als je 
//de compiler setting: strictNullChecks op TRUE instelt
var myNumber : number | null;
myNumber = 5;
myNumber = null;


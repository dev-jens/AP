
// oefeningen callback (cb) functies
//----------------------------------
var Lijst1: string[] = ["OPEL", "FORD", "BMW", "SEAT", "TESLA", "MERCEDES", "SKODA"]
var Lijst2: number[] = [3, 10, 0, 1, 5, 15, 2, 7]

//Filteren van een lijst:

//callback functie afzonderlijk definiëren
var filterFun = (item) => item.length == 4;
//filteren van de lijst mbv. de cb functie
var gefilterdeLijst = Lijst1.filter(filterFun);

console.log("gefilterde lijst op lengte == 4:");
//afdrukken van de gefilterde lijst in de console, ook mbv. van een callback functie
gefilterdeLijst.forEach((item) => console.log(item));

// filteren van de lijst op de eerste letter == 'S'
//gefilterdeLijst = Lijst1.filter((item) => item.startsWith("S"))

console.log("gefilterde lijst op starten met 'S':");
//afdrukken van de gefilterde lijst in de console, ook mbv. van een callback functie
gefilterdeLijst.forEach((item) => console.log(item));

// om te bepalen of de index van het getal even is, moeten we de index mee naar de cb-functie laten doorgeven.
// De index is steeds de 2e parameter.
// om te bepalen of de index even is, moet de rest van een deling door 2 gelijk zijn aan 0
var filterFunOpEvenElementen = (item, index) => index % 2 == 0;
gefilterdeLijst = Lijst1.filter(filterFunOpEvenElementen);

console.log("gefilterde lijst op de elementen op een even index in de lijst:");
//afdrukken van de gefilterde lijst in de console, ook mbv. van een callback functie
gefilterdeLijst.forEach((item) => console.log(item));

// Sorteren van een lijst: oplopende sortering volgens lengte (zie ook de online documentatie van de Array.sort functie)
var gesorteerdeLijst = Lijst1.sort((item1, item2) => item1.length == item2.length ? 0 : item1.length > item2.length ? 1 : -1);

console.log("gesorteerde lijst op de lengte van de elementen in oplopende volgorde:");
//afdrukken van de gesorteerde lijst in de console, ook mbv. van een callback functie
gesorteerdeLijst.forEach((item) => console.log(item));

// Sorteren van een lijst: aflopende sortering volgens lengte (zie ook de online documentatie van de Array.sort functie)
gesorteerdeLijst = Lijst1.sort((item1, item2) => item1.length == item2.length ? 0 : item1.length > item2.length ? -1 : 1);

console.log("gesorteerde lijst op de lengte van de elementen in aflopende volgorde:");
//afdrukken van de gesorteerde lijst in de console, ook mbv. van een callback functie
gesorteerdeLijst.forEach((item) => console.log(item));

//Wat doet overigens een sort zonder cb-functie...?
gesorteerdeLijst = Lijst1.sort();
console.log("gesorteerde lijst zonder gebruik van een cb-functie:");
//afdrukken van de gesorteerde lijst in de console, ook mbv. van een callback functie
gesorteerdeLijst.forEach((item) => console.log(item));

// nu gaan we getallen sorteren met de sort functie, ook zonder gebruik te maken van een eigen cb-functie
var gesorteerdeLijst2 = Lijst2.sort();

console.log("gesorteerde lijst van getallen in oplopende volgorde: ");
console.log("(oeps dit lijkt niet correct te werken)");
//afdrukken van de gesorteerde lijst in de console, ook mbv. van een callback functie
gesorteerdeLijst2.forEach((item) => console.log(item));

//De reden waarom de standaard sort niet werkt met getallen kan je vinden in de online documentatie (zoek op)
//Dus dan toch ook maar een eigen cb-functie gebruiken...
var gesorteerdeLijst2 = Lijst2.sort((item1, item2) => item1 == item2 ? 0 : item1 > item2 ? 1 : -1)

console.log("gesorteerde lijst van getallen in oplopende volgorde, poging 2: ");
//afdrukken van de gesorteerde lijst in de console, ook mbv. van een callback functie
gesorteerdeLijst2.forEach((item) => console.log(item));
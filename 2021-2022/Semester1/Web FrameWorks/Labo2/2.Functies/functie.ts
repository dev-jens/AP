// Maak een functie die
// Het kwadraat van een getal berekend.

function kwadraat(getal : number){
    return getal**2;
}

// arrow function
var kwad = (get : number) => get**2;

// een tekst: string en een count: number verwacht
// een string[ ] teruggeeft, met lengte count en inhoud tekst

function CreateArr(text : string , count : number) : string[] {
    var arrayString : string[] = [];
  
    
    for(var i = 0; i < text.length; i++){
        arrayString[i] = text;
    }
    return arrayString;
} 

// arrow function
var CreateArr2 = (text : string ,cnt : number = 5) : string[] => {
    var arrayString2 : string[] = [];

    for(var i = 0; i < cnt; i++){
        arrayString2[i] = text;
    }
    return arrayString2;
};

// Maak een “anonymous” functie die
// een tekst : string verwacht
// En optioneel een separator : string met default waarde = “-” 
// Die een string[ ] teruggeeft waarbij de text werd opgesplitst adhv. de separator
var anonymous = (tekst : string , separator: string = "-") : string[] => {

    return tekst.split(separator)    
}

// Maak een functie om het product te maken van een onbekend aantal parameters
var product = (get : number , ...getallen :number[]) => {
    var prod : number = 1;
    for(var i = 0; i < getallen.length; i++){
        prod *= getallen[i] ;
    }
    return prod * get;
}

// gestrutureerde mededeling (GM)

var mededeling = (jaar : number, klantNr : number = 0, bestelnr : number) => {

}


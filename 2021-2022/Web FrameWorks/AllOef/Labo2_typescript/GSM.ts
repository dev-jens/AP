
//Stel een gestructureerde mededeling (GSM) samen aan de hand van 3 parameters (jaar, klant en bestelNr)
//en voeg het controlegetal toe => cc = jjjkkkkbbb % 97
//het formaat is ***jjj/kkkk/bbbcc*** 
function GSM(jaar: number, klantNr: number = 0, bestelNr: number = 0, decoratie : string = "*", scheiding: string = "/"): string {
    var sJaar : string;
    
    if (jaar <= 99)
        //jaar => bv. 17
        sJaar = PadLeft(jaar.toString(), 3);
    else
        //jaar => bv. 2017, neem de laatste 2 tekens met de "substring" functie
        sJaar = PadLeft(jaar.toString().substr(2), 3);

    var sKlant = PadLeft(klantNr.toString(), 4);
    var sBestel = PadLeft(bestelNr.toString(), 3);

    var totaal = sJaar + sKlant + sBestel;
    var controle = PadLeft((Number(totaal) % 97).toString(), 2);

    //strings samenvoegen mbv. 'backticks'
    var deco = `${decoratie}${decoratie}${decoratie}`
    return `${deco}${sJaar}${scheiding}${sKlant}${scheiding}${sBestel}${controle}${deco}`
}

//Vul de tekst links aan met het padTeken tot de opgegeven lengte bereikt is.
//bv. tekst: 17, lengte = 3 => maakt van '17' -> '017'
function PadLeft(tekst: string, lengte: number, padTeken: string = "0") {
    while (tekst.length < lengte) {
        tekst = padTeken + tekst;
    }
    return tekst;
}

console.log(GSM(2017, 123, 1));
console.log(GSM(17, 123, 1));
//***017/0123/00136***
console.log(GSM(2017))


//Kwadraat
function PowerOf2 (nr: number)
{
    return nr * nr;
    // beter: gebruik de javascript Math class 
    // return Math.pow(nr, 2);
}


console.log(PowerOf2(5));

//kopieer tekst in een array
function CopyTekst (tekst:string, aantal:number)
{
    var result: string[] = [];
    for (let index = 0; index < aantal; index++) {
        result.push(tekst);
    }
    return result;
}

var copyResult = CopyTekst("AP 2019", 34);
console.log(copyResult.length)
console.log(copyResult[5]);

var SplitText = function (text: string, separator: string = "-")
{
    var result = text.split(separator);
    return result;
}

var splitted = SplitText("123-394-4556-12");
console.log(splitted.length)

//Product van onbekend aantal waarden
//gebruik de rest parameter (...)
function Multiply (...nr: number[])
{
    var result = 1;
    for(let teller = 0; teller < nr.length; teller ++)
        result *= nr[teller];

    //een array heeft een foreach methode
    //waarbij een callback functie kan worden
    //gebruikt 
    // nr.forEach(element => {
    //   result *= element;  
    // });
    return result;
}

console.log(Multiply(4,5,2));

//zelfde functies maar dan als Lambda expressions
//fat arrow functions
var lPowerOf2Fun = (nr) => nr*nr;
console.log(lPowerOf2Fun(4));

var lCopyText = (tekst:string, aantal:number) =>
{
    var result: string[] = [];
    for (let index = 0; index < aantal; index++) {
        result.push(tekst);
    }
    return result;
}

var res = lCopyText("AP AP", 10)
console.log(res.length)

var lSplitText = (text: string, separator: string = "-") => text.split(separator);

var splitresult = lSplitText("222-333-444")
console.log (splitresult.length)

var lMulti = (...nr: number[]) =>
{
    var result = 1;
    for(let teller = 0; teller < nr.length; teller ++)
        result *= nr[teller];

    //een array heeft een foreach methode
    //waarbij een callback functie kan worden
    //gebruikt 
    // nr.forEach(element => {
    //   result *= element;  
    // });
    return result;
}

console.log(lMulti(4,5,2,1));


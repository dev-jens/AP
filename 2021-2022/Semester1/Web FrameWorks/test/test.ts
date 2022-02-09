import * as math from "./hello" 

//standard
function CalculateLenght(text : string): number{
    return text.length
}
//variable fun
let calc = function (text : string) : number{
    return text.length
}
// arrow function
let sum = (num : number, num2:number) =>{
    var sum = num + num2
    return sum
}
// arrow function direct return
let sum2 = (num : number, num2:number) => num + num2


let list: number[] = [1,3,54,388,24,346,2,1]
list.forEach((value , index) => {
    console.log(index + "" + value)
});

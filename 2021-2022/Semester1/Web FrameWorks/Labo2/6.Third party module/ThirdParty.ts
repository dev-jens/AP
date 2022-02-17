import * as Math from 'mathjs';
import * as _ from "lodash";
import * as momnt from "moment";
// math
console.log("vierkantswortel van 100 = " + Math.sqrt(100))
const num = Math.unit("15 cm")
const num2 = Math.unit("50 inch")

console.log('------------------------------')
console.log(num.to('inch').toString())

console.log('------------------------------')
console.log(num2.to('cm').toString())

console.log("Lodash _____________")
console.log(_.VERSION)

console.log("Moment-_-___--__----__")
console.log(momnt.version)
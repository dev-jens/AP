const csvToJson = require('convert-csv-to-json');

let fileInputName = 'info.csv'; 
let fileOutputName = 'outputcsv.json';

csvToJson.generateJsonFileFromCsv(fileInputName,fileOutputName);
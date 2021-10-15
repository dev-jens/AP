@AbapCatalog.sqlViewName: 'ZSD040SCOUNTER'
@AbapCatalog.compiler.compareFilter: true
@AbapCatalog.preserveKey: true
@AccessControl.authorizationCheck: #CHECK
@EndUserText.label: 'Interface view SCOUNTER'
define view ZSD_040_SCOUNTER as select from scounter {
    
    key carrid as Airline,//Airline
    key countnum as Number_Sales_Office,//number of sales
    airport as Airpor_Code //airport code
}

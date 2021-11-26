@AbapCatalog.sqlViewName: 'ZSD040SCARR'
@AbapCatalog.compiler.compareFilter: true
@AbapCatalog.preserveKey: true
@AccessControl.authorizationCheck: #CHECK
@EndUserText.label: 'Interface view SCARR'


define view ZSD_040_SCARR as select from scarr {
    


    key carrid as Airline_Code,
    carrname as Airline_Name,
    currcode as Local_Currency_Airline,
    url as Airline_Url
    
}

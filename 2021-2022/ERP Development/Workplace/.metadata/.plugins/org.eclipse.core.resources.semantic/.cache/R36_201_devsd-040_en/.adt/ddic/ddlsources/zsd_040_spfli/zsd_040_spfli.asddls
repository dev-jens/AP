@AbapCatalog.sqlViewName: 'ZSD040SPFLI'
@AbapCatalog.compiler.compareFilter: true
@AbapCatalog.preserveKey: true
@AccessControl.authorizationCheck: #CHECK
@EndUserText.label: 'Interface view Flights Schedule'
define view ZSD_040_SPFLI as select from spfli {

    key carrid as Airline_Code,
    key connid as Connection_Number,
    countryfr as Country_From,
    cityfrom as Departure_City,
    airpfrom as Departure_Airport,
    countryto as Country_to,
    cityto as Destionation_City,
    airpto as Destionation_Airport,
    fltime as Flight_Time,
    deptime as Departure_time,
    arrtime as Arrival_time,
    distance as Distance,
    distid as Distance_Mass_unit,
    fltype as Flight_type,
    period as Period
    
}

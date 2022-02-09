@AbapCatalog.sqlViewName: 'ZSD040CCARRIERS'
@AbapCatalog.compiler.compareFilter: true
@AbapCatalog.preserveKey: true
@AccessControl.authorizationCheck: #CHECK
@EndUserText.label: 'CARRIERS'

@OData.publish: true
@Search.searchable: true
@UI.headerInfo: {
  typeName: 'Airline',
  typeNamePlural: 'Airlines',
  title: {
    value: 'Airline_Code',
    type: #STANDARD
  },
  description: {
    value: 'Airline_Name',
    type: #STANDARD
  }
}

define view ZSD_040_C_CARRIERS as select from ZSD_040_SCARR{

  
  @UI.lineItem: [{position: 10, label: 'AirlineCode'}]
  @Search.defaultSearchElement: true
  @Search.fuzzinessThreshold: 0.8
  key Airline_Code,
  
  
  @UI.lineItem: [{position: 20, label: 'Airline Name' }]
  @Search.defaultSearchElement: true
  @Search.fuzzinessThreshold: 0.8
  Airline_Name,
  
  @UI.lineItem: [{position: 30, label: 'Local Currency' }]
  @UI.selectionField.position : 10
  //@Search.defaultSearchElement: true
  //@Search.fuzzinessThreshold: 0.4
  Local_Currency_Airline,
 
  @UI.lineItem: [{position: 40, label: 'Website URL'}]
  @Search.defaultSearchElement: true
  @Search.fuzzinessThreshold: 0.8
  Airline_Url
}

@AbapCatalog.sqlViewName: 'ZSD_040_TEST_C'
@AbapCatalog.compiler.compareFilter: true
@AbapCatalog.preserveKey: true
@AccessControl.authorizationCheck: #CHECK
@EndUserText.label: 'fiori test'

@OData.publish: true

define view ZSD_040_C_TEST_VIEW as select from ZSD_040_TEST_VIEW2 {


        key Id,
        key Dat,
        Pilot,
        Copilot,
        Attend1,
        Attend2,
        Attend3,
        Attend4

        
    
}

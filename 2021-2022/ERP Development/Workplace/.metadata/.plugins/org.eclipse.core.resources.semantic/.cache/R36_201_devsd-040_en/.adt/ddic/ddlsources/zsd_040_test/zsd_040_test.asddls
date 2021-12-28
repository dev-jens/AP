@AbapCatalog.sqlViewName: 'ZSD040TEST'
@AbapCatalog.compiler.compareFilter: true
@AbapCatalog.preserveKey: true
@AccessControl.authorizationCheck: #CHECK
@EndUserText.label: 'test vieuws'
define view ZSD_040_TEST as select from pa0001 {

    key mandt as Mandt,
    key pernr as Pernr,
    key subty as Subty,
    key objps as Objps,
    key sprps as Sprps,
    key endda as Endda,
    key begda as Begda,
    key seqnr as Seqnr
  
    
}

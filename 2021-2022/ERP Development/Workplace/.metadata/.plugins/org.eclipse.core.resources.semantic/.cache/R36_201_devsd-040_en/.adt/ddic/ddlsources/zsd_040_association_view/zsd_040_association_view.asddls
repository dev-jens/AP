@AbapCatalog.sqlViewName: ''
@AbapCatalog.compiler.compareFilter: true
@AbapCatalog.preserveKey: true
@AccessControl.authorizationCheck: #CHECK
@EndUserText.label: 'Interface view Association view'
define view ZSD_040_Association_view as select from data_source_name
association [1] to target_data_source_name as _association_name
    on $projection.element_name = _association_name.target_element_name {
    
    _association_name // Make association public
}
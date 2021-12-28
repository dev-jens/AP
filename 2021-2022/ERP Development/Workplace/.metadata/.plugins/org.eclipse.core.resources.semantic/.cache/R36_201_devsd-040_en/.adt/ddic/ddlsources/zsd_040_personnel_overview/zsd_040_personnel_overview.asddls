@AbapCatalog.sqlViewName: 'ZSD040PERS_VIEW'
@AbapCatalog.compiler.compareFilter: true
@AbapCatalog.preserveKey: true
@AccessControl.authorizationCheck: #CHECK
@EndUserText.label: 'overview personnel'


define view ZSD_040_PERSONNEL_OVERVIEW as select from pa0001 as pa1  
left outer join pa0002 as pa2
    on pa1.pernr = pa2.pernr   
    { 
  
     key pa1.pernr as Personel_Number,
     pa2.nchmc as Lastname,
     pa2.vnamc as Firstname,
     concat_with_space(pa2.nchmc, pa2.vnamc, 1) as Fullname,
     cast(pa2.gbdat as abap.dats(8)) as birthday,
     pa1.werks as Personel_Area,
     pa1.bukrs as Company_Code,
     pa1.btrtl as Personel_Subgroup

}
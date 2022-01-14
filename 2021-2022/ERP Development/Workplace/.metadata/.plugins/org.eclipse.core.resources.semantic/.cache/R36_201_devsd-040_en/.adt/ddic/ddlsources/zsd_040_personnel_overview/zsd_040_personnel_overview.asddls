@AbapCatalog.sqlViewName: 'ZSD040PERS_VIEW'
@AbapCatalog.compiler.compareFilter: true
@AbapCatalog.preserveKey: true
@AccessControl.authorizationCheck: #CHECK
@EndUserText.label: 'overview personnel'

/*
    beste, je kan geen join leggen tussen de tabbelen pa000(1-2) en de hrp1000.
    ik heb alle mogelijke opties geprobeerd maar geen van deze werkte helaas.
    het zou normaal gezien moeten lukken met verschillende velden maar om 1 of andere mysterieuse reden
    werkte geen een van deze velden 100 %.Daarom heb ik de join van HRP1000 in commentaar gezet zodat alle
    andere vereisten de correcte data vertonen.
    
    Mvg
    Baeten Jens
     
*/
define view ZSD_040_PERSONNEL_OVERVIEW as select from pa0001 as pa1  
inner  join pa0002 as pa2
    on pa1.pernr = pa2.pernr
//inner  join hrp1000 as hrp
     //on hrp.seqnr = pa1.seqnr
    { 
    
     key pa1.pernr as Personel_Number,
     pa2.nchmc as Lastname,
     pa2.vnamc as Firstname,
     pa2.gbdat as Birthday,
     pa1.werks as Personnel_Area,
     pa1.bukrs as Company_Code,
     pa1.btrtl as Personnel_Subgroup //,
    // hrp.stext as Organization_Unit_Name
}
// where pa1.endda > pa1.begda //laat al de current users zien die nog in het bedrijf zitten 


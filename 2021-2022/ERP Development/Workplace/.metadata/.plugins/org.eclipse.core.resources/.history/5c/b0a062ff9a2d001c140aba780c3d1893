@AbapCatalog.sqlViewName: 'ZSD040CURRCON'
@AbapCatalog.compiler.compareFilter: true
@AbapCatalog.preserveKey: true
@AccessControl.authorizationCheck: #CHECK
@EndUserText.label: 'Interface view Currency Conversion'
define view ZSD_040_C_Currency_Conversion
with parameters p_displaycurrency : displaycurrency
as select from ZSD_040_SBOOKS {
   
   key Carrier_id,
   key Connection_id,
   key Flight_date,
   key Booking_id,
   Customer_id,
   Customer_type,
   Foreign_currency_price,
   Payment_currency,
   currency_price,
   Local_currency,
   
   @EndUserText.label: 'Price (in EUR)'
   currency_conversion( amount => currency_price, 
                      source_currency => Local_currency,    
                      target_currency => :p_displaycurrency, 
                      exchange_rate_date => Flight_date, 
                      error_handling => 'SET_TO_NULL' ) as PriceInEUR
 
} 

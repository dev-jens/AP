@AbapCatalog.sqlViewName: 'ZSD040SFLIGHT'
@AbapCatalog.compiler.compareFilter: true
@AbapCatalog.preserveKey: true
@AccessControl.authorizationCheck: #CHECK
@EndUserText.label: 'Interface view Flights'
define view ZSD_040_SFLIGHT as select from sflight {
     
     //key mandt as mandt,
     key carrid as Carrier_id,
     key connid as Connection_number,
     key fldate as Flight_date,
     price as Price,
     currency as Airline_Currency,
     planetype as Plane_type,
     seatsmax as Maximum_Seats_Eco,
     seatsocc as Occupied_Seats_Eco,
     paymentsum as Total_Sum_Bookings,
     seatsmax_b as Maximum_Seats_Bus,
     seatsocc_b as Occupied_Seats_Bus,
     seatsmax_f as Maximum_Seats_First,
     seatsocc_f as Occupied_Seats_First
    
}

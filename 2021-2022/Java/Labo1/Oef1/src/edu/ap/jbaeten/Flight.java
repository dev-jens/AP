package edu.ap.jbaeten;

import java.time.LocalTime;

public class Flight {
    Destination destination;
    String departure;
    int flightNr;
    LocalTime DepartureTime;
    public  Flight(){

    }
    public Flight(Destination destination, int flightNr, LocalTime DepartureTime) {
        this.destination = destination;
        this.departure = "Brussel";
        this.flightNr = flightNr;
        this.DepartureTime = DepartureTime;
    }

    @Override
    public String toString() {
        return "Flight{" +
                "destination=" + destination +
                ", departure='" + departure + '\'' +
                ", flightNr=" + flightNr +
                ", DepartureTime=" + DepartureTime +
                '}';
    }
}

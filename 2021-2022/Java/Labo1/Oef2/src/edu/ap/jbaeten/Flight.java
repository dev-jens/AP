package edu.ap.jbaeten;
import java.time.LocalTime;
import java.util.Arrays;

public class Flight {
    Destination destination;
    String departure;
    int flightNr;
    LocalTime DepartureTime;
    Passenger[] passengers;

    public Flight(Destination destination, int flightNr,Passenger[] passengers, LocalTime DepartureTime) {
        this.destination = destination;
        this.departure = "Brussel";
        this.flightNr = flightNr;
        this.passengers = passengers;
        this.DepartureTime = DepartureTime;
    }

    @Override
    public String toString() {
        return "Flight{" +
                "destination=" + destination +
                ", departure='" + departure + '\'' +
                ", flightNr=" + flightNr +
                ", DepartureTime=" + DepartureTime +
                ", passengers=" + Arrays.toString(passengers) +
                '}';
    }
}

package lab1.oef1;

import java.time.LocalTime;

public class Flight {
    Destination destination;
    String departure;
    int flightNr;
    LocalTime DepartureTime;

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

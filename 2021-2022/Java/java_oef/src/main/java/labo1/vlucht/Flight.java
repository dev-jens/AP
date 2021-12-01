package labo1.vlucht;

import java.time.LocalDate;
import java.time.LocalTime;
import java.util.ArrayList;
import java.util.Date;

public class Flight {


    private Destinations destination;
    private Departure departure;
    private Integer flightNum;
    private LocalTime departureTime;
    private ArrayList passList;


    public Flight(Destinations destination, Departure departure, Integer flightNum, LocalTime departureTime, ArrayList passList) {
        this.destination = destination;
        this.departure = departure;
        this.flightNum = flightNum;
        this.departureTime = departureTime;
        this.passList = passList;
    }

    @Override
    public String toString() {
        return "Flight{" +
                "destination=" + destination +
                ", departure=" + departure +
                ", flightNum=" + flightNum +
                ", departureTime=" + departureTime +
                ", passList=" + passList +
                '}';
    }
}

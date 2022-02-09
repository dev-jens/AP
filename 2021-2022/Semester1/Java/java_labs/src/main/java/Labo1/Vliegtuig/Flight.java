package Labo1.Vliegtuig;

import java.util.ArrayList;

public class Flight {

    // destination
    private Destination destination;
    //departure
    private Departure departure;
    // flight number
    private Integer fightNumber;
    // constructor
    private ArrayList<Passenger> passengersList;


    public Flight(Destination destination, Departure departure, Integer fightNumber, ArrayList<Passenger> passengersList) {
        this.destination = destination;
        this.departure = departure;
        this.fightNumber = fightNumber;
        this.passengersList = passengersList;
    }

    public Destination getDestination() {
        return destination;
    }

    public void setDestination(Destination destination) {
        this.destination = destination;
    }

    public Departure getDeparture() {
        return departure;
    }

    public void setDeparture(Departure departure) {
        this.departure = departure;
    }

    public Integer getFightNumber() {
        return fightNumber;
    }

    public void setFightNumber(Integer fightNumber) {
        this.fightNumber = fightNumber;
    }

    @Override
    public String toString() {
        return "FLight{" +
                "destination=" + destination +
                ", departure=" + departure +
                ", fightNumber=" + fightNumber +
                '}';
    }
}

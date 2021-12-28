package Labo1.Vliegtuig;

import java.util.ArrayList;

public class FlightController {
    public static void main(String[] args) {

        Passenger p1 = new Passenger("Baeten","Jens",4444);
        Passenger p2 = new Passenger("Doe","Jhon",1294);

        ArrayList<Passenger> passengerList= new ArrayList<>();
        passengerList.add(p1);
        passengerList.add(p2);

        System.out.println(passengerList);

    }
}

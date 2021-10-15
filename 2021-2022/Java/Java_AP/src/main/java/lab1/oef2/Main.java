package lab1.oef2;
import lab1.oef1.Destination;
import lab1.oef1.Passenger;

import java.time.LocalTime;

public class Main {
    public static void main(String[] args) {
        Passenger p1 = new Passenger("Jens", "Baeten", 42069);
        Passenger p2 = new Passenger("Didier", "Baeten", 23144);
        Passenger p3 = new Passenger("Yari", "Baeten", 838424);
        Passenger p4 = new Passenger("Saskia", "Van Geel", 98842);

        Passenger[] passengers = {p1,p2,p3,p4};

        Flight flight1 = new Flight(Destination.Parijs , 420,passengers, LocalTime.MIDNIGHT);
        System.out.println(flight1);

    }
}

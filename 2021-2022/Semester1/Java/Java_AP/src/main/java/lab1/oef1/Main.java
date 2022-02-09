package lab1.oef1;

import java.time.LocalTime;

public class Main {
    public static void main(String[] args) {
        Flight flight1 = new Flight(Destination.Parijs,420, LocalTime.MIDNIGHT);

        Passenger p1 = new Passenger("Jens","Baeten",flight1,8384);

        System.out.println(flight1);
        System.out.println(p1);

    }
}

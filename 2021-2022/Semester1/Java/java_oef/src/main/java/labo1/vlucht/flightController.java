package labo1.vlucht;
import javax.sound.midi.Soundbank;
import java.time.LocalDate;
import java.time.LocalTime;
import java.util.ArrayList;

public class flightController {

    public static void main(String[] args) {

        ArrayList passengerList = new ArrayList();
        passengerList.add( new Passenger("jens","baeten",LocalDate.of(2001,5,9),69696));
        passengerList.add(new Passenger("joske","vermeulen",72368));


        Flight flightToParis = new Flight(Destinations.PARIS,Departure.BRUSSEL,234324,LocalTime.MIDNIGHT,passengerList);
        System.out.println(flightToParis);




    }
}

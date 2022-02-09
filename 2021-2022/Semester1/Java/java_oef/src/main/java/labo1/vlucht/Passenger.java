package labo1.vlucht;

import java.time.LocalDate;
import java.util.Date;

public class Passenger {

    private String name;
    private String lastname;
    private LocalDate birthdate = null;
    private Integer socialNumber;
    private Flight flight;

    public Passenger(String name, String lastname, LocalDate birthdate, Integer socialNumber, Flight flight) {
        this.name = name;
        this.lastname = lastname;
        this.birthdate = birthdate;
        this.socialNumber = socialNumber;
        this.flight = flight;
    }

    public Passenger(String name, String lastname, LocalDate birthdate, Integer socialNumber) {
        this.name = name;
        this.lastname = lastname;
        this.birthdate = birthdate;
        this.socialNumber = socialNumber;
    }

    public Passenger(String name, String lastname, Integer socialNumber) {
        this.name = name;
        this.lastname = lastname;
        this.socialNumber = socialNumber;
    }

    public LocalDate getBirthdate() {
        return birthdate;
    }

    public void setBirthdate(LocalDate birthdate) {
        this.birthdate = birthdate;
    }

    @Override
    public String toString() {
        return "Passenger{" +
                "name='" + name + '\'' +
                ", lastname='" + lastname + '\'' +
                ", birthdate=" + birthdate +
                ", socialNumber=" + socialNumber +
                '}';
    }
}

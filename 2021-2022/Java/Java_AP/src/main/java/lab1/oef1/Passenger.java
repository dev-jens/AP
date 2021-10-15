package lab1.oef1;

import java.time.LocalDate;

public class Passenger {
    String Name;
    String FirstName;
    Flight flight;
    int socialnumber;

    private LocalDate BirthDate = null;
    //getter
    public LocalDate getBirthDate() {
        return BirthDate;
    }
    //setter
    public void setBirthDate(LocalDate birthDate) {
        BirthDate = birthDate;
    }

    public Passenger(String name, String firstName, Flight flight, int socialnumber) {
        Name = name;
        FirstName = firstName;
        this.flight = flight;
        this.socialnumber = socialnumber;
    }

    public Passenger(String name, String firstName, Flight flight  , LocalDate birthDate, int socialnumber) {
        this.Name = name;
        this.FirstName = firstName;
        this.flight = flight;
        this.BirthDate = birthDate;
        this.socialnumber = socialnumber;
    }

    public Passenger(String name, String firstName, int socialnumber) {
        Name = name;
        FirstName = firstName;
        this.socialnumber = socialnumber;
    }

    @Override
    public String toString() {
        return "Passenger{" +
                "Name='" + Name + '\'' +
                ", FirstName='" + FirstName + '\'' +
                ", flight=" + flight +
                ", socialnumber=" + socialnumber +
                ", BirthDate=" + BirthDate +
                '}';
    }
}

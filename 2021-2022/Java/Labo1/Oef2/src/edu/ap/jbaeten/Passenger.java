package edu.ap.jbaeten;

import java.time.LocalDate;

public class Passenger {
    String Name;
    String FirstName;
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

    public Passenger(String name, String firstName, int socialnumber) {
        Name = name;
        FirstName = firstName;
        this.socialnumber = socialnumber;
    }

    public Passenger(String name, String firstName, LocalDate birthDate, int socialnumber) {
        this.Name = name;
        this.FirstName = firstName;
        this.BirthDate = birthDate;
        this.socialnumber = socialnumber;
    }

    @Override
    public String toString() {
        return "Passenger{" +
                "Name='" + Name + '\'' +
                ", FirstName='" + FirstName + '\'' +
                ", socialnumber=" + socialnumber +
                ", BirthDate=" + BirthDate +
                '}';
    }
}

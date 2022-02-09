package Labo1.Vliegtuig;

import java.time.LocalDate;

public class Passenger {

    private String name;
    private String firstname;
    private LocalDate birthday;
    private int socialNumber;


    public Passenger(String name, String firstname, int socialNumber) {
        this.name = name;
        this.firstname = firstname;
        this.socialNumber = socialNumber;
       ;
    }

    public Passenger(String name, String firstname, LocalDate birthday, int socialNumber ) {
        this.name = name;
        this.firstname = firstname;
        this.birthday = birthday;
        this.socialNumber = socialNumber;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getFirstname() {
        return firstname;
    }

    public void setFirstname(String firstname) {
        this.firstname = firstname;
    }

    public LocalDate getBirthday() {
        return birthday;
    }

    public void setBirthday(LocalDate birthday) {
        this.birthday = birthday;
    }

    public int getSocialNumber() {
        return socialNumber;
    }

    public void setSocialNumber(int socialNumber) {
        this.socialNumber = socialNumber;
    }



    @Override
    public String toString() {
        return "Passenger{" +
                "name='" + name + '\'' +
                ", firstname='" + firstname + '\'' +
                ", birthday=" + birthday +
                ", socialNumber=" + socialNumber +
                '}';
    }
}

package edu.ap.webservice.grading.jpa;

import java.util.Objects;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.Id;


@Entity
public class Grade {
    
    @Id
    @GeneratedValue
    private Long id;

    @Column
    private String Firstname;

    @Column
    private String Lastname;
    
    @Column
    private int grade;

    public Grade() {
    }

    public Grade(Long id, String Firstname, String Lastname, int grade) {
        this.id = id;
        this.Firstname = Firstname;
        this.Lastname = Lastname;
        this.grade = grade;
    }

    public Long getId() {
        return this.id;
    }

    public void setId(Long id) {
        this.id = id;
    }

    public String getFirstname() {
        return this.Firstname;
    }

    public void setFirstname(String Firstname) {
        this.Firstname = Firstname;
    }

    public String getLastname() {
        return this.Lastname;
    }

    public void setLastname(String Lastname) {
        this.Lastname = Lastname;
    }

    public int getGrade() {
        return this.grade;
    }

    public void setGrade(int grade) {
        this.grade = grade;
    }

    public Grade id(Long id) {
        setId(id);
        return this;
    }

    public Grade Firstname(String Firstname) {
        setFirstname(Firstname);
        return this;
    }

    public Grade Lastname(String Lastname) {
        setLastname(Lastname);
        return this;
    }

    public Grade grade(int grade) {
        setGrade(grade);
        return this;
    }

    @Override
    public boolean equals(Object o) {
        if (o == this)
            return true;
        if (!(o instanceof Grade)) {
            return false;
        }
        Grade grading = (Grade) o;
        return Objects.equals(id, grading.id) && Objects.equals(Firstname, grading.Firstname) && Objects.equals(Lastname, grading.Lastname) && grade == grading.grade;
    }

    @Override
    public int hashCode() {
        return Objects.hash(id, Firstname, Lastname, grade);
    }

    @Override
    public String toString() {
        return "{" +
            " id='" + getId() + "'" +
            ", Firstname='" + getFirstname() + "'" +
            ", Lastname='" + getLastname() + "'" +
            ", grade='" + getGrade() + "'" +
            "}";
    }



}

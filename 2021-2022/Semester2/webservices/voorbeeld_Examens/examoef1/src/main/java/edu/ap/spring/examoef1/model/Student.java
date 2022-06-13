package edu.ap.spring.examoef1.model;

import java.time.LocalDate;
import javax.persistence.*;

@Entity
public class Student {
    
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;
    
    @Column
    private String firstname;
    
    @Column
    private String lastname;
    
    @Column
    private LocalDate dateOfBirth;
    
    @Column
    private String studyProgram;



    public Student() {
    }

    public Student(String firstname, String lastname, LocalDate dateOfBirth, String studyProgram) {
        this.firstname = firstname;
        this.lastname = lastname;
        this.dateOfBirth = dateOfBirth;
        this.studyProgram = studyProgram;
    }

    public Long getId() {
        return this.id;
    }

    public void setId(Long id) {
        this.id = id;
    }

    public String getFirstname() {
        return this.firstname;
    }

    public void setFirstname(String firstname) {
        this.firstname = firstname;
    }

    public String getLastname() {
        return this.lastname;
    }

    public void setLastname(String lastname) {
        this.lastname = lastname;
    }

    public LocalDate getDateOfBirth() {
        return this.dateOfBirth;
    }

    public void setDateOfBirth(LocalDate dateOfBirth) {
        this.dateOfBirth = dateOfBirth;
    }

    public String getStudyProgram() {
        return this.studyProgram;
    }

    public void setStudyProgram(String studyProgram) {
        this.studyProgram = studyProgram;
    }

    @Override
    public String toString() {
        return "{" +
            " id='" + getId() + "'" +
            ", firstname='" + getFirstname() + "'" +
            ", lastname='" + getLastname() + "'" +
            ", dateOfBirth='" + getDateOfBirth() + "'" +
            ", studyProgram='" + getStudyProgram() + "'" +
            "}";
    }
}

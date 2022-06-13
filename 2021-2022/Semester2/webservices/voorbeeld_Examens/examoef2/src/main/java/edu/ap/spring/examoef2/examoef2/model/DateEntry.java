package edu.ap.spring.examoef2.examoef2.model;

import java.time.LocalDate;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;

@Entity
public class DateEntry {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;

    @Column
    private LocalDate checkedDate;

    @Column
    private Boolean valid;

    @Column
    private Long days;


    public DateEntry() {
    }

    public DateEntry(LocalDate checkedDate, Boolean valid, Long days) {
        this.checkedDate = checkedDate;
        this.valid = valid;
        this.days = days;
    }

    public Long getId() {
        return this.id;
    }

    public void setId(Long id) {
        this.id = id;
    }

    public LocalDate getCheckedDate() {
        return this.checkedDate;
    }

    public void setCheckedDate(LocalDate checkedDate) {
        this.checkedDate = checkedDate;
    }

    public Boolean isValid() {
        return this.valid;
    }

    public Boolean getValid() {
        return this.valid;
    }

    public void setValid(Boolean valid) {
        this.valid = valid;
    }

    public Long getDays() {
        return this.days;
    }

    public void setDays(Long days) {
        this.days = days;
    }

    @Override
    public String toString() {
        return "{" +
            " id='" + getId() + "'" +
            ", checkedDate='" + getCheckedDate() + "'" +
            ", valid='" + isValid() + "'" +
            ", days='" + getDays() + "'" +
            "}";
    }


    
}

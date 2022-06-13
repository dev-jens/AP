package edu.ap.spring.jpa;

import javax.persistence.*;

import org.springframework.stereotype.Component;

@Component
@Entity
public class Wallet {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;

    @Column
    private String walletname;

    @Column
    private float Balance;


    public Wallet() {
    }

    public Wallet(String walletname, float Balance) {
        this.walletname = walletname;
        this.Balance = Balance;
    }

    public Long getId() {
        return this.id;
    }

    public void setId(Long id) {
        this.id = id;
    }

    public String getWalletname() {
        return this.walletname;
    }

    public void setWalletname(String walletname) {
        this.walletname = walletname;
    }

    public float getBalance() {
        return this.Balance;
    }

    public void setBalance(float Balance) {
        this.Balance = Balance;
    }

    @Override
    public String toString() {
        return "{" +
            " id='" + getId() + "'" +
            ", walletname='" + getWalletname() + "'" +
            ", Balance='" + getBalance() + "'" +
            "}";
    }
   



}



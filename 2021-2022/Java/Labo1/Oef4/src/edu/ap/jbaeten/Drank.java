package edu.ap.jbaeten;

public class Drank {

    protected double price;
    protected String name;

    public Drank(double price, String name) {
        this.price = price;
        this.name = name;
    }

    @Override
    public String toString() {
        return "Drank{" +
                "price=" + price +
                ", name='" + name + '\'' +
                '}';
    }
}

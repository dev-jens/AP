package edu.ap.jbaeten;

public class NonAlcolischeDranken extends Drank{
    private boolean HeeftGas;

    public NonAlcolischeDranken(double price, String name, boolean heeftGas) {
        super(price, name);
        HeeftGas = heeftGas;
    }
    @Override
    public String toString() {
        return "NonAlcolischeDranken{" +
                "price=" + price +
                ", name='" + name + '\'' +
                ", HeeftGas=" + HeeftGas +
                '}';
    }
}

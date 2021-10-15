package edu.ap.jbaeten;

public class AlcolischeDranken extends Drank{

    private double percentge;

    public AlcolischeDranken(double price, String name, double percentge) {
        super(price, name);
        this.percentge = percentge;
    }

    @Override
    public String toString() {
        return "AlcolischeDranken {" +
                "percentge=" + percentge +
                ", price=" + price +
                ", name='" + name + '\'' +
                '}';
    }
}

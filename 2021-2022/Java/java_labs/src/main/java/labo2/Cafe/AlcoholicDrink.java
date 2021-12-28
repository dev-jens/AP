package labo2.Cafe;

public class AlcoholicDrink extends Drink {

    private double percentage;


    public AlcoholicDrink(String name, double price, double percentage) {
        super(name, price);
        this.percentage = percentage;
    }

    @Override
    public String toString() {
        return "AlcoholicDrink{" +
                "percentage=" + percentage +
                ", name='" + name + '\'' +
                ", price=" + price +
                '}';
    }
}

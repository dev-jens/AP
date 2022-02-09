package labo1.Cafe;

public class AlcoholicDrink extends Drink {

    private Double percentage;

    public AlcoholicDrink(String name, double price, Double percentage) {
        super(name, price);
        this.percentage = percentage;
    }

    @Override
    public String  toString() {
        return "AlcoholicDrink{" +
                "percentage=" + percentage +
                ", name='" + name + '\'' +
                ", price=" + price +
                '}';
    }
}

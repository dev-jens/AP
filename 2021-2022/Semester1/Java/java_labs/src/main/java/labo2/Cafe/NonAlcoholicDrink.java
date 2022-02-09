package labo2.Cafe;

public class NonAlcoholicDrink extends Drink{

    private boolean bubbles;

    public NonAlcoholicDrink(String name, double price, boolean bubbles) {
        super(name, price);
        this.bubbles = bubbles;
    }

    @Override
    public String toString() {
        return "NonAlcoholicDrink{" +
                "name='" + name + '\'' +
                ", price=" + price +
                ", bubbles=" + bubbles +
                '}';
    }
}

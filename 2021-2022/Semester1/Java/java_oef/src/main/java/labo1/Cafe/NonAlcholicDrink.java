package labo1.Cafe;

public class NonAlcholicDrink extends Drink {

    private boolean bubbles;

    public NonAlcholicDrink(String name, double price, boolean bubbles) {
        super(name, price);
        this.bubbles = bubbles;
    }

    @Override
    public String toString() {
        return "NonAlcholicDrink{" +
                "name='" + name + '\'' +
                ", price=" + price +
                ", bubbles=" + bubbles +
                '}';
    }
}

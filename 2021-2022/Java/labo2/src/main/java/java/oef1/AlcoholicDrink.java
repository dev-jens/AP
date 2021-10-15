package java.oef1;

public class AlcoholicDrink extends Drink {

    private double percentage;

    public AlcoholicDrink(double price, String name, double percentge) {
        super(price, name);
        this.percentage = percentge;
    }

    @Override
    public String toString() {
        return "AlcoholicDrink{" +
                "percentage=" + percentage +
                '}';
    }
}

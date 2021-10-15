package java.oef1;

public class NonAlcoholicDrink extends Drink {
    private boolean hasGas;

    public NonAlcoholicDrink(double price, String name, boolean heeftGas) {
        super(price, name);
        hasGas = heeftGas;
    }

    @Override
    public String toString() {
        return "NonAlcoholicDrink{" +
                "price=" + price +
                ", name='" + name + '\'' +
                ", hasGas=" + hasGas +
                '}';
    }
}

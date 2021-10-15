package java.oef1;

abstract class Drink {

    protected double price;
    protected String name;

    public Drink(double price, String name) {
        this.price = price;
        this.name = name;
    }

    @Override
    public String toString() {
        return "Drink{" +
                "price=" + price +
                ", name='" + name + '\'' +
                '}';
    }
}

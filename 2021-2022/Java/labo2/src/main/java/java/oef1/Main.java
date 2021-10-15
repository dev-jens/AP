package java.oef1;

import java.util.ArrayList;

public class Main {
    public static void main(String[] args) {

        var whiskey = new AlcoholicDrink(19.99, "whiskey", 7.4);
        var cola = new NonAlcoholicDrink(2.3, "cola", true);
        ArrayList<Drink> lijst = new ArrayList<Drink>();
        System.out.println(whiskey);
        System.out.println(cola);
    }
}

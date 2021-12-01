package labo1.Cafe;

import java.util.ArrayList;
import java.util.List;

public class CaffeController {

    public static void main(String[] args) {

        List<Drink> drinks = new ArrayList<Drink>();
        drinks.add(new AlcoholicDrink("tequilla sunrise",12.43,10.4));
        drinks.add(new NonAlcholicDrink("sprait",3,true));

        drinks.forEach(drink -> {
            System.out.println("drink Info :" + drink.name);
            System.out.println("price: " + drink.price );

        });



    }
}

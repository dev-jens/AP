package labo1.Cafe;

import java.util.ArrayList;
import java.util.List;
import java.util.Objects;

public class DrinkList {

    private List<Drink> drinks = new ArrayList<Drink>();

    public List<Drink> getDrinks() {
        return drinks;
    }

    public void AddDrink(Drink drink){
        drinks.add(drink);
    }

    @Override
    public String toString() {
        String string = "DrinkList{\n";

        for(Drink drink : drinks) {
            String drinkString = drink.toString();
            string += drinkString + "\n";
        }

        return string;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        DrinkList drinkList = (DrinkList) o;
        return Objects.equals(drinks, drinkList.drinks);
    }

    @Override
    public int hashCode() {
        return Objects.hash(drinks);
    }
}

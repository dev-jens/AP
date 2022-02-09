package labo6.pizzatool;

import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

public class Main {

    public static void main(String[] args) {
        String filePath = "";
        List<Pizza> pizzas = new ArrayList<>();

        try {
            FileReader reader = new FileReader(filePath);
            BufferedReader br = new BufferedReader(reader);
            String line = br.readLine();
            while (line != null) {
                pizzas.add(handleCSVLine(line));
                line = br.readLine();
            }
            br.close();

        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }


    }

    private static Pizza handleCSVLine(String line) {
        String[] strings = line.split(";");
        Pizza pizza = new Pizza();
        pizza.setName(strings[0]);
        pizza.setPrice(strings[1]);
        pizza.setType(strings[2]);
        pizza.addIngredients(strings[3]);
        return pizza;
    }

}


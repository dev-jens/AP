import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

public class CsvLoader {

    public List<Pizza> loadCSV() {
        List<Pizza> pizzas = new ArrayList<>();
        try {
            FileReader reader = new FileReader("target/classes/files/pizza.csv");
            BufferedReader br = new BufferedReader(reader);
            String line = br.readLine();
            //ignore first line
            line = br.readLine();
            while (line != null) {
                pizzas.add(handleCSVLine(line));
                line = br.readLine();
            }
            br.close();
            reader.close();
        } catch (IOException e) {
            e.printStackTrace();
        }
        return pizzas;
    }

    private Pizza handleCSVLine(String line) {
        String[] strings = line.split(";");
        Pizza pizza = new Pizza();
        pizza.setName(strings[0]);
        pizza.setPrice(strings[1]);
        pizza.setType(strings[2]);
        pizza.addIngredients(strings[3]);
        return pizza;
    }
}

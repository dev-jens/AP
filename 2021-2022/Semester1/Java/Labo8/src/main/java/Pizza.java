import java.util.ArrayList;
import java.util.List;

public class Pizza {
    private String name;
    private String price;
    private String type;
    private String ingredients;
    private List<String> listOfIngredients;

    public Pizza() {
        this.listOfIngredients = new ArrayList<>();
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getPrice() {
        return price;
    }

    public void setPrice(String price) {
        this.price = price;
    }

    public String getType() {
        return type;
    }

    public void setType(String type) {
        this.type = type;
    }

    public List<String> getListOfIngredients() {
        return listOfIngredients;
    }

    public void addIngredients(String ingredients) {
        this.ingredients = ingredients;
        String[] strings = ingredients.replace(" en ", " , ").replace(" & ", " , ").split(",");
        for (String ingredient : strings) {
            ingredient = ingredient.replace("25%", "").replace("1/4", "").replace("extra", "").replace("dubbel", "").replace("een zakje", "");
            this.listOfIngredients.add(ingredient.toLowerCase().trim());
        }
    }
}

import java.util.Comparator;
import java.util.HashSet;
import java.util.List;
import java.util.Set;
import java.util.stream.Collectors;

public class PizzaTool {
    private final List<Pizza> pizzaList;
    private final Set<String> ingredients;

    public PizzaTool(CsvLoader loader) {
        this.pizzaList = loader.loadCSV();
        this.ingredients = new HashSet<>();
        for (Pizza pizza : pizzaList) {
            ingredients.addAll(pizza.getListOfIngredients());
        }
    }

    public List<String> getUniquePizzaTypes() {
        return pizzaList.stream()
                .map(Pizza::getType)
                .distinct()
                .sorted()
                .collect(Collectors.toList());
    }

    public List<Pizza> getPizzasForType(String pizzaType) {
        return pizzaList.stream()
                .filter(p -> p.getType().equals(pizzaType))
                .sorted(Comparator.comparing(Pizza::getName))
                .collect(Collectors.toList());
    }

    public List<Pizza> getPizzasForIngredient(String ingredient) {
        return pizzaList.stream()
                .filter(p -> p.getListOfIngredients().contains(ingredient))
                .sorted(Comparator.comparing(Pizza::getName))
                .collect(Collectors.toList());
    }

    public List<String> getIngredients() {
        return ingredients.stream().sorted().collect(Collectors.toList());
    }
}

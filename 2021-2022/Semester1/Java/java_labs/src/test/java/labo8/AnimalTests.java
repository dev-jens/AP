package labo8;

import labo8.Animal;
import labo8.AnimalType;
import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;
import static org.junit.jupiter.api.Assertions.assertNotEquals;

public class AnimalTests {

    @Test
    void createCat(){
        Animal cat = new Animal("pluisje", AnimalType.CAT, "De Jens");
        assertEquals("pluisje", cat.getName());
        assertEquals(AnimalType.CAT, cat.getType());
        assertEquals("De Jens", cat.getOwner());
    }

    @Test
    void createNewCatIsNotDawg(){
        Animal cat = new Animal("pluisje", AnimalType.CAT, "De Jens");
        assertNotEquals(AnimalType.DOG, cat.getType());
    }

    @Test
    void catMakesSound(){
        Animal cat = new Animal("pluisje", AnimalType.CAT, "De Jens");
        assertEquals("MEOW",cat.makeSound());

    }

    @Test
    void catMakesOtherSound(){
        Animal cat = new Animal("pluisje", AnimalType.CAT, "De Jens");
        assertNotEquals("WOEF",cat.makeSound());

    }
    @Test
    void changeOwner(){
        Animal cat = new Animal("pluisje", AnimalType.CAT, "De Jens");
        cat.changeOwner("jens");

        assertEquals("jens",cat.getOwner());
        assertNotEquals("De Jens",  cat.getOwner());

    }

    @Test
    void dogMakesSound(){
        Animal dog = new Animal("pluisje", AnimalType.DOG, "De Jens");
        assertEquals("BARK",dog.makeSound());

    }

}

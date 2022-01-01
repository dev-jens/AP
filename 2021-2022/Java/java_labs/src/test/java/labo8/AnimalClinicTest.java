package labo8;

import labo8.Animal;
import labo8.AnimalClinic;
import labo8.AnimalType;
import org.junit.jupiter.api.Test;

import java.util.ArrayList;
import java.util.List;

import static org.junit.jupiter.api.Assertions.*;

class AnimalClinicTest {


    @Test
    void addOneAnimal() {
        Animal beau = new Animal("beau" , AnimalType.DOG,"Jens");
        AnimalClinic animalClinic = new AnimalClinic();
        animalClinic.addAnimal(beau);
        assertEquals(1, animalClinic.countAnimals());

    }
    @Test
    void addTwoDiffrentAnimal() {
        Animal beau = new Animal("beau" , AnimalType.DOG,"Jens");
        Animal flor = new Animal("flor" , AnimalType.DOG,"amber");
        AnimalClinic animalClinic = new AnimalClinic();
        animalClinic.addAnimal(beau);
        animalClinic.addAnimal(flor);
        assertEquals(2, animalClinic.countAnimals());

    }
    @Test
    void addTwoSameAnimal() {
        Animal beau = new Animal("beau" , AnimalType.DOG,"Jens");
        Animal beau2 = new Animal("beau" , AnimalType.DOG,"Jens");
        AnimalClinic animalClinic = new AnimalClinic();
        animalClinic.addAnimal(beau);
        animalClinic.addAnimal(beau2);
        assertNotEquals(2, animalClinic.countAnimals());

    }

    @Test
    void findOneAnimal() {
        Animal beau = new Animal("beau" , AnimalType.DOG,"Jens");
        AnimalClinic animalClinic = new AnimalClinic();
        animalClinic.addAnimal(beau);

        assertEquals(beau, animalClinic.findAnimal("beau",AnimalType.DOG));

    }
    @Test
    void FindTwoAnimals() {
        Animal beau = new Animal("beau" , AnimalType.DOG,"Jens");
        Animal flor = new Animal("flor" , AnimalType.DOG,"amber");
        AnimalClinic animalClinic = new AnimalClinic();
        animalClinic.addAnimal(beau);
        animalClinic.addAnimal(flor);
        assertEquals(flor, animalClinic.findAnimal("flor", AnimalType.DOG));

    }
    @Test
    void FindUnExistingAnimal() {
        Animal beau = new Animal("beau" , AnimalType.DOG,"Jens");
        AnimalClinic animalClinic = new AnimalClinic();
        animalClinic.addAnimal(beau);
        assertNull(animalClinic.findAnimal("flor", AnimalType.DOG));

    }

    @Test
    void countEmptyAnimalList() {
        AnimalClinic animalClinic = new AnimalClinic();
        assertEquals(0 , animalClinic.countAnimals());
    }

    @Test
    void countAnimal() {
        List<Animal> animalList = new ArrayList<>();
        AnimalClinic animalClinic = new AnimalClinic();
        for (int i = 0; i < 10; i++) {
            animalList.add( new Animal("beau V" + i , AnimalType.DOG,"Jens"));
        }
        for (Animal animal:animalList)
        {
            animalClinic.addAnimal(animal);
        }

        assertEquals(10 , animalClinic.countAnimals());
    }

    @Test
    void FindAnimalOwners(){
        Animal beau = new Animal("beau" , AnimalType.DOG,"Jens");
        Animal baco = new Animal("baco" , AnimalType.DOG,"Jens");
        Animal flor = new Animal("flor" , AnimalType.DOG,"amber");
        AnimalClinic animalClinic = new AnimalClinic();
        animalClinic.addAnimal(beau);
        animalClinic.addAnimal(flor);

        List<Animal> aList = new ArrayList<>();
        System.out.println(animalClinic.findAllAnimalsForOwner("Jens"));

       //assertTrue(animalClinic.findAllAnimalsForOwner("Jens").equals(aList));

    }
}
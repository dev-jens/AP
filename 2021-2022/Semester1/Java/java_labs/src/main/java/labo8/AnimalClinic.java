package labo8;

import java.util.HashSet;
import java.util.List;
import java.util.Optional;
import java.util.Set;
import java.util.stream.Collectors;

public class AnimalClinic {
    private final Set<Animal> animals;

    public AnimalClinic() {
        this.animals = new HashSet<>();
    }

    /**
     * Adds an unique Animal to the clinic.
     *
     * @param animal
     * @return the number of animals in the clinic
     */
    public int addAnimal(Animal animal) {
        this.animals.add(animal);
        return animals.size();
    }

    /**
     * Change the owner of an Animal in the clinic
     *
     * @param name name of the animal
     * @param type type of the animal : CAT or DOG
     * @param newOwner name of the new owner
     * @return true animal found and owner changed, false animal not found
     */
    public boolean changeAnimalOwner(String name, AnimalType type, String newOwner) {
        Optional<Animal> animal = animals.stream().filter(p -> p.getName().equals(name) && p.getType().equals(type)).findFirst();
        animal.ifPresent(p -> p.changeOwner(newOwner));
        return animal.isPresent();
    }

    /**
     * Finds an Animal in the clinic
     *
     * @param name name of the animal
     * @param type type of the animal : CAT or DOG
     * @return the animal if found or NULL if not found
     */
    public Animal findAnimal(String name, AnimalType type) {
        return animals.stream().filter(p -> p.getName().equals(name) && p.getType().equals(type)).findFirst().orElse(null);
    }

    /**
     * Counts the number of Animals in the clinic
     *
     * @return the number of animals in the clinic
     */
    public int countAnimals() {
        return animals.size();
    }

    /**
     * Finds all animals for an owner
     *
     * @param owner name of the owner
     * @return list of Animals for the owner
     */
    public List<Animal> findAllAnimalsForOwner(String owner) {
        return animals.stream().filter(p -> p.getOwner().equals(owner)).collect(Collectors.toList());
    }
}

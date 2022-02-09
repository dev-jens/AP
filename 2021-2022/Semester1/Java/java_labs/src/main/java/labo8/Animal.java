package labo8;

import java.util.Objects;

public class Animal {

    private final String name;
    private final AnimalType type;
    private String owner;

    public Animal(String name, AnimalType type, String owner) {
        this.name = name;
        this.type = type;
        this.owner = owner;
    }

    public String getName() {
        return name;
    }

    public AnimalType getType() {
        return type;
    }

    public String getOwner() {
        return owner;
    }

    public void changeOwner(String newOwner) {
        this.owner = newOwner;
    }

    public String makeSound() {
        switch (type) {
            case CAT:
                return "MEOW";
            case DOG:
                return "BARK";
        }
        return null;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        Animal animal = (Animal) o;
        return name.equals(animal.name) && type == animal.type;
    }

    @Override
    public int hashCode() {
        return Objects.hash(name, type);
    }
}

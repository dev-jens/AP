
import org.junit.jupiter.api.Test;
import static org.junit.jupiter.api.Assertions.*;


public class AnimalClinicTests {

    @Test
    void addAnimalCheckAdded(){
        AnimalClinic clinic = new AnimalClinic();
        Animal dier  = new Animal("flup",AnimalType.DOG,"jens");
        int result = clinic.addAnimal(dier);
        assertEquals(1, result);

    }

    @Test
    void add2Animal(){
        AnimalClinic clinic = new AnimalClinic();
        Animal dier  = new Animal("flup",AnimalType.DOG,"jens");
        Animal dier2  = new Animal("flap",AnimalType.DOG,"jens");

        clinic.addAnimal(dier);
        int result = clinic.addAnimal(dier2);
        assertEquals(2, result);
    }

    @Test
    void add2SameAnimal(){
        AnimalClinic clinic = new AnimalClinic();
        Animal dier  = new Animal("flup",AnimalType.DOG,"jens");
        Animal dier2  = new Animal("flup",AnimalType.DOG,"jens");


        clinic.addAnimal(dier);
        int result = clinic.addAnimal(dier2);
        assertEquals(2, result);
    }

    @Test
    void findAnimal(){
        AnimalClinic clinic = new AnimalClinic();
        Animal dier  = new Animal("flup",AnimalType.DOG,"jens");
        clinic.addAnimal(dier);
        Animal a1 = clinic.findAnimal(dier.getName(), dier.getType());
        assertEquals(dier, a1);
    }

    @Test
    void TwoAnimalOneFind(){
        AnimalClinic clinic = new AnimalClinic();
        Animal dier  = new Animal("flup",AnimalType.DOG,"jens");
        Animal dier2  = new Animal("Flap",AnimalType.DOG,"jens");
        clinic.addAnimal(dier);
        Animal a1 = clinic.findAnimal(dier.getName(), dier.getType());
        assertEquals(dier, a1);
    }

    @Test
    void AddAnimalSearchOther(){

        AnimalClinic clinic = new AnimalClinic();
        Animal dier  = new Animal("flup",AnimalType.DOG,"jens");
        clinic.addAnimal(dier);
        Animal a1 = clinic.findAnimal(dier.getName(), dier.getType());
        assertEquals(dier, a1);

    }


}

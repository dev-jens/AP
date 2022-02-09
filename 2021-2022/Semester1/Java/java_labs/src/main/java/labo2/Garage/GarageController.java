package labo2.Garage;

import java.util.Collections;

public class GarageController {
    public static void main(String[] args) {
        Garage garage = new Garage();

        SportCar sportCar1 = new SportCar(5, CarType.ELECTRIC, CarBrand.TESLA, 2560.2f, 101, "1ABC123", 150);
        SportCar sportCar2 = new SportCar(2, CarType.HYBRID, CarBrand.AUDI, 9673.3f, 203, "1BCA231", 100);
        FamilyCar familyCar = new FamilyCar(7, CarType.SUV, CarBrand.VOLVO, 10568.6f, 101, "1CAB312", 7, true);

        garage.AddCar(sportCar1);
        garage.AddCar(sportCar2);
        garage.AddCar(familyCar);

        garage.Sort();
        System.out.print("Sorted as normal: " + garage);

        garage.Sort(new SortByKmDriven());
        System.out.print("Sorted by km: " + garage);
    }
}

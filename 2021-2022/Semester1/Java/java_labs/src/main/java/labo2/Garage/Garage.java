package labo2.Garage;

import java.util.*;

public class Garage {
    List<Car> carList = new ArrayList<>();

    public List<Car> getCars() {
        return carList;
    }

    public void AddCar(Car car){
        carList.add(car);
    }

    public void Sort(){
        Collections.sort(carList);
    }

    public void Sort(Comparator<Car> comparator){
        Collections.sort(carList, comparator);
    }



    @Override
    public String toString() {
        String string = "Garage {\n";

        for(Car car : carList)
            string += car.toString() + "\n";

        string += "} \n";
        return string;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (!(o instanceof Garage)) return false;
        Garage garage = (Garage) o;
        return carList.equals(garage.carList);
    }

    @Override
    public int hashCode() {
        return Objects.hash(carList);
    }
}

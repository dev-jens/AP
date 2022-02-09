package labo2.Garage;

import java.util.Comparator;

public class SortByKmDriven implements Comparator<Car> {

    @Override
    public int compare(Car o1, Car o2) {
        if(o1.getKmDriven() == o2.getKmDriven())
            return 0;
        else if(o1.getKmDriven() > o2.getKmDriven())
            return 1;
        else
            return -1;
    }
}

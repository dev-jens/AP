package labo2.Garage;

import java.util.Objects;

public class Car implements Comparable<Car> {

    protected Integer sequenceNumber;
    protected CarType type;
    protected CarBrand brand;
    protected float kmDriven;
    protected Integer chassisNumber;
    protected String licencePlate;

    public Integer getSequenceNumber() {
        return sequenceNumber;
    }

    public CarType getType() {
        return type;
    }

    public CarBrand getBrand() {
        return brand;
    }

    public Integer getChassisNumber() {
        return chassisNumber;
    }

    public float getKmDriven() {
        return kmDriven;
    }

    public void setKmDriven(float kmDriven) {
        this.kmDriven = kmDriven;
    }

    public String getLicencePlate() {
        return licencePlate;
    }

    public void setLicencePlate(String licencePlate) {
        this.licencePlate = licencePlate;
    }

    public Car(Integer sequenceNumber, CarType type, CarBrand brand, float kmDriven, Integer chassisNumber, String licencePlate) {
        this.sequenceNumber = sequenceNumber;
        this.type = type;
        this.brand = brand;
        this.kmDriven = kmDriven;
        this.chassisNumber = chassisNumber;
        this.licencePlate = licencePlate;
    }

    @Override
    public String toString() {
        return "Car{" +
                "sequenceNumber=" + sequenceNumber +
                ", type=" + type +
                ", brand=" + brand +
                ", kmDriven=" + kmDriven +
                ", chassisNumber=" + chassisNumber +
                ", licencePlate='" + licencePlate + '\'' +
                '}';
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (!(o instanceof Car)) return false;
        Car car = (Car) o;
        return Float.compare(car.getKmDriven(), getKmDriven()) == 0 && getSequenceNumber().equals(car.getSequenceNumber()) && getType() == car.getType() && getBrand() == car.getBrand() && getChassisNumber().equals(car.getChassisNumber()) && getLicencePlate().equals(car.getLicencePlate());
    }

    @Override
    public int hashCode() {
        return Objects.hash(getSequenceNumber(), getType(), getBrand(), getKmDriven(), getChassisNumber(), getLicencePlate());
    }

    @Override
    public int compareTo(Car o) {
        if (this.sequenceNumber == o.sequenceNumber)
            return 0;
        else if (this.sequenceNumber > o.sequenceNumber){
            return 1;
        }else{
            return -1;
        }

    }
}

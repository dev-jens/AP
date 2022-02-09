package labo2.Garage;

public class SportCar  extends Car{

    private Integer pk;


    public Integer getPk() {
        return pk;
    }

    public void setPk(Integer pk) {
        this.pk = pk;
    }

    public SportCar(Integer sequenceNumber, CarType type, CarBrand brand, float kmDriven, Integer chassisNumber, String licencePlate, Integer pk) {
        super(sequenceNumber, type, brand, kmDriven, chassisNumber, licencePlate);
        this.pk = pk;
    }

    @Override
    public String toString() {
        return "SportCar{" +
                "sequenceNumber=" + sequenceNumber +
                ", type=" + type +
                ", brand=" + brand +
                ", kmDriven=" + kmDriven +
                ", chassisNumber=" + chassisNumber +
                ", licencePlate='" + licencePlate + '\'' +
                ", pk=" + pk +
                '}';
    }
}

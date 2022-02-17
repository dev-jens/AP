package labo2.Garage;

public class FamilyCar extends Car{

    private Integer seats;
    private Boolean towBar;

    public Integer getSeats() {
        return seats;
    }

    public void setSeats(Integer seats) {
        this.seats = seats;
    }

    public Boolean getTowBar() {
        return towBar;
    }

    public void setTowBar(Boolean towBar) {
        this.towBar = towBar;
    }

    public FamilyCar(Integer sequenceNumber, CarType type, CarBrand brand, float kmDriven, Integer chassisNumber, String licencePlate, Integer seats , boolean towBar) {
        super(sequenceNumber, type, brand, kmDriven, chassisNumber, licencePlate);
        this.seats = seats;
        this.towBar = towBar;
    }


    @Override
    public String toString() {
        return "FamilyCar{" +
                "sequenceNumber=" + sequenceNumber +
                ", type=" + type +
                ", brand=" + brand +
                ", kmDriven=" + kmDriven +
                ", chassisNumber=" + chassisNumber +
                ", licencePlate='" + licencePlate + '\'' +
                ", seats=" + seats +
                ", towBar=" + towBar +
                '}';
    }
}

package labo2.Garage;

public class Car {

    private String sequenceNumber;
    private String brand;
    private float kmDriven;
    private Integer chassisNumber;
    private String licencePlate;


    public String getSequenceNumber() {
        return sequenceNumber;
    }

    public void setSequenceNumber(String sequenceNumber) {
        this.sequenceNumber = sequenceNumber;
    }

    public String getBrand() {
        return brand;
    }

    public void setBrand(String brand) {
        this.brand = brand;
    }

    public float getKmDriven() {
        return kmDriven;
    }

    public void setKmDriven(float kmDriven) {
        this.kmDriven = kmDriven;
    }

    public Integer getChassisNumber() {
        return chassisNumber;
    }

    public void setChassisNumber(Integer chassisNumber) {
        this.chassisNumber = chassisNumber;
    }

    public String getLicencePlate() {
        return licencePlate;
    }

    public void setLicencePlate(String licencePlate) {
        this.licencePlate = licencePlate;
    }
}

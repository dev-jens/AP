package oef3.entity;
import javax.persistence.*;

@Entity
@Table(name = "movie")

public class Movie {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "id")
    private int id;

    @Column(name = "title")
    private String name;

    @Column(name = "releaseYear")
    private int releaseYear;

    @Column(name = "star_code")
    private  int starCode;

    public Movie() {
    }

    public Movie(String name, int releaseYear, int starCode) {
        this.name = name;
        this.releaseYear = releaseYear;
        this.starCode = starCode;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public int getReleaseYear() {
        return releaseYear;
    }

    public void setReleaseYear(int releaseYear) {
        this.releaseYear = releaseYear;
    }

    public int getStarCode() {
        return starCode;
    }

    public void setStarCode(int starCode) {
        this.starCode = starCode;
    }
}

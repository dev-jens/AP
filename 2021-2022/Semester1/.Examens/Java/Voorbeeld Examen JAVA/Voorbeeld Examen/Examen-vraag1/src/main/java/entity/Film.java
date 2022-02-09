package entity;
import javax.persistence.*;

@Entity
@Table(name = "film")
public class Film {

        //showId, title, director, country, releaseYear & description

        @Id
        @Column(name = "showId")
        private int showId;

        @Column(name = "title")
        private String title;

        @Column(name = "director")
        private String director;

        @Column(name = "country")
        private String country;

        @Column(name = "releaseYear")
        private int releaseYear;

        @Column(name = "description")
        private String description;

        public Film() {
        }

        public Film(int showId, String title, String director, String country, int releaseYear, String description) {
            this.showId = showId;
            this.title = title;
            this.director = director;
            this.country = country;
            this.releaseYear = releaseYear;
            this.description = description;
        }

        public int getShowId() {
            return showId;
        }

        public void setShowId(int showId) {
            this.showId = showId;
        }

        public String getTitle() {
            return title;
        }

        public void setTitle(String title) {
            this.title = title;
        }

        public String getDirector() {
            return director;
        }

        public void setDirector(String director) {
            this.director = director;
        }

        public String getCountry() {
            return country;
        }

        public void setCountry(String country) {
            this.country = country;
        }

        public int getReleaseYear() {
            return releaseYear;
        }

        public void setReleaseYear(int releaseYear) {
            this.releaseYear = releaseYear;
        }

        public String getDescription() {
            return description;
        }

        public void setDescription(String description) {
            this.description = description;
        }

    @Override
    public String toString() {
        return "Film\n" +
                "showId= " + showId +
                " title=' " + title + '\n' +
                " director=' " + director + '\n' +
                " country=' " + country + '\n' +
                " releaseYear= " + releaseYear +  '\n' +
                " description=' " + description + '\n'
                ;
    }
}

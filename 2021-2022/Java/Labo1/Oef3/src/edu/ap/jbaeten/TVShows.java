package edu.ap.jbaeten;
import java.time.LocalDate;

public class TVShows {
   private String name;
   private Person showHost;
   private int timeLenght;
   private LocalDate airTime;
   private Genre genre;

    public TVShows(String name, Person showHost, int timeLenght, LocalDate airTime, Genre genre) {
        this.name = name;
        this.showHost = showHost;
        this.timeLenght = timeLenght;
        this.airTime = airTime;
        this.genre = genre;
    }
}

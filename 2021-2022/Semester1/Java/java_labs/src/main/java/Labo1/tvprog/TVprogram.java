package Labo1.tvprog;

import java.time.LocalDate;

public class TVprogram {
    private String name;
    private Host host;
    private Integer timelenght;
    private LocalDate broadCastTime;
    private Genre genre;

    public TVprogram(String name, Host host, Integer timelenght, LocalDate broadCastTime, Genre genre) {
        this.name = name;
        this.host = host;
        this.timelenght = timelenght;
        this.broadCastTime = broadCastTime;
        this.genre = genre;
    }
}

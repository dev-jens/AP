package oef3.service;

import oef3.dao.MovieDao;
import oef3.dao.MovieException;
import oef3.entity.Movie;

public class MovieService {

    private final MovieDao dao;

    public MovieService(MovieDao dao){
        this.dao = dao;
    }

    public void addMovie(String title, int year,int stars)throws MovieException{

        if (stars < 1 || stars > 5){
            throw new MovieException("probleem");
        }
        Movie movie = new Movie(title,year,stars);
        dao.saveMovie(movie);
    }

}

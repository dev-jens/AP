package oef3.dao;

import oef3.entity.Movie;
import oef3.util.HibernateUtil;
import org.hibernate.Session;
import org.hibernate.Transaction;

import java.time.Year;
import java.util.List;

public class MovieDao {

    public void saveMovie(Movie movie) {
        Transaction transaction = null;
        try (Session session = HibernateUtil.getSessionFactory().openSession()) {

            transaction = session.beginTransaction();
            session.save(movie);
            transaction.commit();

        } catch (Exception e) {
            if (transaction != null) {
                transaction.rollback();
            }
            e.printStackTrace();
        }
    }

    public List<Movie> GetMovies() throws MovieException{
        try(Session session = HibernateUtil.getSessionFactory().openSession()) {
            return session.createQuery("SELECT m FROM Movie m", Movie.class).list();
        }catch (Exception e){
            e.printStackTrace();
            throw new MovieException("lezen movie gefaald");
        }
    }

    public List<Movie> GetMovieByStar() {
        try (Session session = HibernateUtil.getSessionFactory().openSession()) {
            return session.createQuery("SELECT m FROM Movie m ORDER BY m.starCode DESC", Movie.class).list();
        }
    }

    public List<Movie> getMovieByYear() {
        try (Session session = HibernateUtil.getSessionFactory().openSession()) {
            return session.createQuery("SELECT m FROM Movie m WHERE m.releaseYear = " + 5, Movie.class).list();
        }
    }
}

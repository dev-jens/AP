package dao;

import entity.Film;
import org.hibernate.Session;
import org.hibernate.Transaction;
import util.HibernateUtil;

import java.util.List;

public class FilmDao {

    public void saveFilm(Film film){
        Transaction transaction = null;
        try(Session session = HibernateUtil.getSessionFactory().openSession()){

            transaction = session.beginTransaction();
            session.save(film);
            transaction.commit();

        } catch(Exception e){
            if(transaction != null){
                transaction.rollback();
            }
            e.printStackTrace();
        }
    }
    public List<Film> getFilms(){
        try(Session session = HibernateUtil.getSessionFactory().openSession()) {
            return session.createQuery("FROM Film", Film.class).list();

        }catch (Exception e){
            e.printStackTrace();
        }
        return null;
    }
    public void searchByYear(int year){
        try(Session session = HibernateUtil.getSessionFactory().openSession()) {
           List<Film> films = session.createQuery("SELECT f FROM Film f WHERE f.releaseYear = "+ year, Film.class).list();
            films.forEach(film -> {
                System.out.println(film.toString());
            });
        }catch (Exception e){
            e.printStackTrace();
        }
    }
    public void searchByTitle(String title){
        try(Session session = HibernateUtil.getSessionFactory().openSession()) {
            List<Film> films = session.createQuery("FROM Film WHERE f.title LIKE '%"+ title +"%'", Film.class).list();
            films.forEach(film -> {
                System.out.println(film.toString());
            });
        }catch (Exception e){
            e.printStackTrace();
        }
    }

}

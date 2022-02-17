package oef3.util;

import oef1.entity.Student;
import oef1.entity.Teacher;
import oef3.entity.Movie;
import org.hibernate.SessionFactory;
import org.hibernate.cfg.Configuration;

public class HibernateUtil {
    private static SessionFactory sessionFactory;

    public static SessionFactory getSessionFactory() {

        if (sessionFactory == null){

            try{
                // get config
                Configuration configuration = new Configuration().configure("hibernate.cfg.xml");

                //add
                configuration.addAnnotatedClass(Movie.class);
                sessionFactory = configuration.buildSessionFactory();

            }catch (Exception e) {
                e.printStackTrace();
            }
        }
        return sessionFactory;
    }
}

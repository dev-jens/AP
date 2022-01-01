package labo9.oef1.util;

import labo9.oef1.entity.Student;
import org.hibernate.SessionFactory;
import org.hibernate.cfg.Configuration;

public class HibernateUtil {

    private static SessionFactory sessionFactory;

    public static SessionFactory getSessionFactory() {

        if (sessionFactory == null){

            try{
                // get config
                Configuration configuration = new Configuration().configure("hibernate.cfg.xml");
                //add config entity class as -> configuration.addAnnotatedClass(entityClass.class):
                configuration.addAnnotatedClass(Student.class);


                sessionFactory = configuration.buildSessionFactory();

            }catch (Exception e) {
                e.printStackTrace();
            }
        }
        return sessionFactory;
    }

}

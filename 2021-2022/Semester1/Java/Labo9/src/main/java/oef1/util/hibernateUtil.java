package oef1.util;
import oef1.entity.Student;
import oef1.entity.Teacher;
import org.hibernate.SessionFactory;
import org.hibernate.cfg.Configuration;


public class hibernateUtil {

    private static SessionFactory sessionFactory;

    public static SessionFactory getSessionFactory() {

        if (sessionFactory == null){

            try{
                // get config
                Configuration configuration = new Configuration().configure("hibernate.cfg.xml");
                //add
                configuration.addAnnotatedClass(Student.class);
                configuration.addAnnotatedClass(Teacher.class);

                sessionFactory = configuration.buildSessionFactory();

            }catch (Exception e) {
                e.printStackTrace();
            }
        }
        return sessionFactory;
    }
}

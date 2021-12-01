package oef1.dao;

import oef1.entity.Student;
import oef1.entity.Teacher;
import oef1.util.hibernateUtil;
import org.hibernate.Session;
import org.hibernate.Transaction;

import java.security.spec.ECField;
import java.util.List;

public class StudentDao {

    public void saveStudent(Student student){
        Transaction transaction = null;
        try(Session session = hibernateUtil.getSessionFactory().openSession()) {

            transaction = session.beginTransaction();
            session.save(student);
            transaction.commit();

        }catch (Exception e){
            if (transaction != null){
                transaction.rollback();
            }
            e.printStackTrace();
        }

    }




    public List<Student> getStudents(){
        try(Session session = hibernateUtil.getSessionFactory().openSession()) {
            return session.createQuery("SELECT s FROM Student s", Student.class).list();

        }catch (Exception e){
            e.printStackTrace();
        }
        return null;
    }

}

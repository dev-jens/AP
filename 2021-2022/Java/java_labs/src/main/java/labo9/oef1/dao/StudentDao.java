package labo9.oef1.dao;

import labo9.oef1.entity.Student;
import labo9.oef1.util.HibernateUtil;
import org.hibernate.Session;
import org.hibernate.Transaction;

import java.util.List;

public class StudentDao {

    public void saveStudent(Student student) {
        Transaction transaction = null;
        try (Session session = HibernateUtil.getSessionFactory().openSession()) {

            transaction = session.beginTransaction();
            session.save(student);
            transaction.commit();

        } catch (Exception e) {
            if (transaction != null) {
                transaction.rollback();
            }
            e.printStackTrace();
        }

    }

    public List<Student> getStudents(){
        try(Session session = HibernateUtil.getSessionFactory().openSession()) {
            return session.createQuery("SELECT s FROM Student s", Student.class).list();

        }catch (Exception e){
            e.printStackTrace();
        }
        return null;
    }

    public void deleteStudent(Student student){

        try(Session session = HibernateUtil.getSessionFactory().openSession()) {
//            student = session.get(Student.class,student.getId());
            session.delete(student);
            System.out.println("\n " + student.getEmail() + " is verwijdert??");


        }catch (Exception e){
            e.printStackTrace();
        }
    }


}

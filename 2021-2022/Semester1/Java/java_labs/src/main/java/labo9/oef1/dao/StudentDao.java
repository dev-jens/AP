package labo9.oef1.dao;

import labo9.oef1.entity.Student;
import labo9.oef1.util.HibernateUtil;
import org.hibernate.Session;
import org.hibernate.Transaction;

import java.util.List;

public class StudentDao {

    // add a student to the list , deze geeft ook een student terug zodat je die kan gebruiken in u main
    public Student Create(String firstname ,String lastname , String email) {
        // create student
        Student student = new Student(firstname, lastname, email);

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
        return student;
    }

    // add object from main to DB
    public void AddStudent(Student student){
        Transaction transaction = null;
        try(Session session = HibernateUtil.getSessionFactory().openSession()){

            transaction = session.beginTransaction();
            session.save(student);
            transaction.commit();

        } catch(Exception e){
            if(transaction != null){
                transaction.rollback();
            }
            e.printStackTrace();
        }
    }

    // get student list to see al the students
    public List<Student> getStudents(){
        try(Session session = HibernateUtil.getSessionFactory().openSession()) {
            return session.createQuery("FROM Student", Student.class).list();

        }catch (Exception e){
            e.printStackTrace();
        }
        return null;
    }

    // update a student id (als de student bestaat zal deze overschreven worden )
    public void update(Student student, Integer id) {
        student.setId(id);

        Transaction transaction = null;
        try(Session session = HibernateUtil.getSessionFactory().openSession()){
            transaction = session.beginTransaction();

            session.update(student);

            transaction.commit();
        } catch(Exception e){
            if(transaction != null){
                transaction.rollback();
            }
            e.printStackTrace();
        }
    }

    // delete a student form the list on ID
    public void Delete(int id) {
        Student student = new Student();
        student.setId(id);

        Transaction transaction = null;
        try (Session session = HibernateUtil.getSessionFactory().openSession()){
            transaction = session.beginTransaction();
            session.delete(student);
            transaction.commit();
        } catch (Exception e) {

            if(transaction != null)
                transaction.rollback();
            e.printStackTrace();
        }
    }

    // delete student on object
    public void Delete(Student student) {
        Transaction transaction = null;
        try (Session session = HibernateUtil.getSessionFactory().openSession()){

            transaction = session.beginTransaction();
            session.delete(student);
            transaction.commit();
        } catch (Exception e) {

            if(transaction != null)
                transaction.rollback();
            e.printStackTrace();
        }
    }

    //

}

package oef1.dao;

import oef1.entity.Student;
import oef1.entity.Teacher;
import oef1.util.hibernateUtil;
import org.hibernate.Session;
import org.hibernate.Transaction;

import java.util.List;

public class TeacherDao {

    public void saveTeacher(Teacher teacher){
        Transaction transaction = null;
        try(Session session = hibernateUtil.getSessionFactory().openSession()) {

            transaction = session.beginTransaction();
            session.save(teacher);
            transaction.commit();

        }catch (Exception e){
            if (transaction != null){
                transaction.rollback();
            }
            e.printStackTrace();
        }
    }
    public List<Teacher> getTeacher(){
        try(Session session = hibernateUtil.getSessionFactory().openSession()) {
            return session.createQuery("SELECT s FROM Teacher s", Teacher.class).list();

        }catch (Exception e){
            e.printStackTrace();
        }
        return null;
    }



}

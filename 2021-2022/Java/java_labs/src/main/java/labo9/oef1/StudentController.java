package labo9.oef1;

import labo9.oef1.dao.StudentDao;
import labo9.oef1.entity.Student;

import java.util.List;

public class StudentController {
    public static void main(String[] args) {

        StudentDao studentDao = new StudentDao();
        Student student = studentDao.Create("jens","baeten","example@ap.be");


        System.out.println("lijst1");
        listPrinter(studentDao);
        studentDao.Delete(2);
        studentDao.update(student, 5);
        System.out.println("lijst2");
        listPrinter(studentDao);





    }

    static void listPrinter(StudentDao dao){
        List<Student> students = dao.getStudents();

        students.forEach(p -> System.out.println(
                "ID: "        +  p.getId()          + "\n" +
                "Firstname: " +  p.getFirstname()   + "\n" +
                "Lastname: "  +  p.getLastname()    + "\n" +
                "E-mail: "    +  p.getEmail()       + "\n"
        ));

    }
}

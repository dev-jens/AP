package labo9.oef1;

import labo9.oef1.dao.StudentDao;
import labo9.oef1.entity.Student;

import java.util.List;

public class StudentController {
    public static void main(String[] args) {

        StudentDao studentDao = new StudentDao();
        Student student = new Student("Jens", "Baeten","Baetenjens07@gmail.com");
        Student student2 = new Student("Amber", "Gillard","Amber.gillard7@gmail.com");
        Student student3 = new Student("Jef", "Van der Avoirt"," jef.v.d.a@live.be");


        studentDao.saveStudent(student);
        studentDao.saveStudent(student2);
        studentDao.saveStudent(student3);
        List<Student> students = studentDao.getStudents();
        listPrinter(students);

        students = studentDao.getStudents();
        studentDao.deleteStudent(student3);
        listPrinter(students);

    }

    static void listPrinter(List<Student> students){
//        List<Student> students = studentDao.getStudents();

        students.forEach(p -> System.out.println(
                "ID: "        +  p.getId()          + "\n" +
                "Firstname: " +  p.getFirstname()   + "\n" +
                "Lastname: "  +  p.getLastname()    + "\n" +
                "E-mail: "    +  p.getEmail()       + "\n"
        ));

    }
}

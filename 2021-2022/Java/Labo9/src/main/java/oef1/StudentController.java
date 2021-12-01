package oef1;

import oef1.dao.StudentDao;
import oef1.dao.TeacherDao;
import oef1.entity.Student;
import oef1.entity.Teacher;

import java.util.List;

public class StudentController {
    public static void main(String[] args) {

        TeacherDao teacherDao = new TeacherDao();
        teacherDao.saveTeacher(new Teacher("jens","baeten","baetenjens07@gmail.com"));
        teacherDao.saveTeacher(new Teacher("jef", "vda","jef.vda@hotmail.com"));
        List<Teacher> teachers = teacherDao.getTeacher();

        StudentDao studentDao = new StudentDao();
        Student student = new Student("joske", "vermeuelen","joskevermeulen@telenet.be");
        student.setTeachers(teachers);
        studentDao.saveStudent(student);

        List<Student> students = studentDao.getStudents();
        students.forEach(p -> System.out.println(
                p.getId() + "-" +
                p.getFirstname() + "-"+
                p.getLastname()
        ));
        students.forEach(p ->
                p.getTeachers().forEach(t-> System.out.println(
                        "name: " + t.getFirstname() + "\n" +
                        "lastname: " + t.getLastname() + "\n" +
                        "email: " + t.getEmail()
                ))
        );
    }
}

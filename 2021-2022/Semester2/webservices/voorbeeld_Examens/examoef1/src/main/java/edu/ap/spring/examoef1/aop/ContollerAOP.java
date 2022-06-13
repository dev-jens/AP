package edu.ap.spring.examoef1.aop;

import java.time.LocalDate;
import java.time.format.DateTimeFormatter;

import org.aspectj.lang.JoinPoint;
import org.aspectj.lang.annotation.Aspect;
import org.aspectj.lang.annotation.Before;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Component;

import edu.ap.spring.examoef1.model.Student;
import edu.ap.spring.examoef1.repository.StudentRepository;

@Component
@Aspect
public class ContollerAOP {
    
    @Autowired
    private StudentRepository studentRepository;

    @Before("execution(public String createStudent(..))")
    public String checkIfStudentExists(JoinPoint joinPoint) throws Throwable {
        
        String firstname = (String) joinPoint.getArgs()[0];
        String lastname = (String) joinPoint.getArgs()[1];
        LocalDate dateOfBirth = (LocalDate) formatToLocalDate((String)joinPoint.getArgs()[2]);
        String studyProgram = (String) joinPoint.getArgs()[3];

        if(studentRepository.existsByFirstnameAndLastname(firstname,lastname)) {
            return "redirect:/listStudent";
        }else{
            studentRepository.save(new Student(firstname, lastname, dateOfBirth, studyProgram));
            return "redirect:/listStudent";
        }

    }

    private LocalDate formatToLocalDate(String date){
        DateTimeFormatter formatter = DateTimeFormatter.ofPattern("yyyy-MM-dd");
        try{
            return LocalDate.parse(date, formatter);
        }catch(Exception e){
            return null;
        }
    }

    

}

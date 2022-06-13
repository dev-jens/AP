package edu.ap.spring.examoef1.controller;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;

import edu.ap.spring.examoef1.repository.StudentRepository;

@Controller
@RequestMapping("/students")
public class StudentController {

    @Autowired
    private StudentRepository studentRepository;

    @GetMapping("/")
    public String index(){
        return "redirect:students/list";
    }
    
    @GetMapping("/list")
    public String getStudentList(Model model){

        model.addAttribute("students", studentRepository.findByOrderByLastnameAsc());
        return "list";
    }

    @GetMapping("/form")
    public String getform(){
        return "form";
    }

    @PostMapping("/create")
    public String createStudent(@RequestParam("firstname") String firstname, @RequestParam("lastname") String lastname, @RequestParam("dateOfBirth") String dateOfBirth, @RequestParam("studyProgram") String studyProgram){

        return "redirect:list";
    }

}

package edu.ap.spring.vraag2.controller;

import java.util.ArrayList;
import java.util.Set;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestParam;

import edu.ap.spring.vraag2.redis.RedisService;

@Controller
public class StudentController {

    @Autowired
    private RedisService service;

    @GetMapping("/")
    private String getIndex() {
        return "redirect:/importStudents";
    }

    @GetMapping("/importStudents")
    private String showForm() {
        return "form";
    }

    @PostMapping("/importStudents")
    private String postFromStudent(@RequestParam("students") String studentsCsv) {

        ArrayList<String> sNumbers = new ArrayList<String>();
        ArrayList<String> studentNames = new ArrayList<String>();

        String[] students = studentsCsv.split(";");
        for (int i = 0; i < students.length; i++) {

            if(i % 2 == 0)
                sNumbers.add(students[i]);
            else
                studentNames.add(students[i]);    
        }

        for(int i=0; i < sNumbers.size(); i++){
            if (!service.exists(sNumbers.get(i))) {
                    service.setKey(sNumbers.get(i), studentNames.get(i));
            }else{
                return "error";
            }

        }

        return "form";
    }

    @GetMapping("/{sNumber}")
    private String getStudentByName(@PathVariable("sNumber") String sNumber, Model model) {

        Set<String> keys = service.keys("*");
        for(String key : keys) {
            if(key.equals(sNumber)) {
                model.addAttribute("name", service.getKey(sNumber));
                return "student";
            }
        }
        model.addAttribute("name", "not found");
        return "student";
    }
    

}

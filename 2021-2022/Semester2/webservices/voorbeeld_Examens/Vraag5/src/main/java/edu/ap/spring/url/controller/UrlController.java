package edu.ap.spring.url.controller;


import javax.servlet.http.HttpServletRequest;

import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.*;

@Controller
public class UrlController {
    
    @GetMapping("/exam/**")
    public String urlSplit(Model model, HttpServletRequest request){
        String[] urlParts = request.getRequestURI().split("/");

        String urlString = "";

        for (String part : urlParts) {
            if(!part.matches("")){
                urlString += part + "--";
            }
        }
       
        urlString = urlString.substring(0, urlString.length() -2);
       
        model.addAttribute("urlString", urlString);
        return "url";
    }
}

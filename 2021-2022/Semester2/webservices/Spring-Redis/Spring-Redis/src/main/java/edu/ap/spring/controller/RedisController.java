package edu.ap.spring.controller;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.Map;
import java.util.Set;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestParam;

import edu.ap.spring.redis.RedisService;

@Controller
public class RedisController {
    
    private String CHANNEL = "edu:ap:redis";
    private ArrayList<String> redisMessages = new ArrayList<String>();
    @Autowired
    private RedisService service;

    @GetMapping("/")
    public String index() {
        return "redirect:/messages";
    }

    // get the page with a list of all messages
    @GetMapping("/messages")
    public String messages(Model model) {
        model.addAttribute("messages", redisMessages);

        return "messages";
    }

    // messaging
    public void onMessage(String message) {
        this.redisMessages.add(message); 
    }

    // get the messaging page
    @GetMapping("/message")
    public String message() {
        return "messageForm";
    }

    // send a new message
    @PostMapping("/message")
    public String saveMessage(@RequestParam("message") String message) {

        service.sendMessage(CHANNEL, message );

        return "redirect:/messages";
    }

    // get the page with a list of movies
    @GetMapping("/movies")
    public String movies(Model model) {
        
        ArrayList<String> movieList = new ArrayList<String>();
        Set<String> movies = service.keys("movies:*");
        for(String m : movies) {
            String movie = "";
            // get hash with actors
            Map<Object, Object> actors = service.hgetAll(m);
            // get all parts of the key, eg : ["movies, "1998", "the Big Lebowski"]
            String[] parts = m.split(":");

            movie += parts[2] + " (" + parts[1] + ") ";
            movie += "Actors: ";
            // iterate over actors
            StringBuilder b = new StringBuilder();
            // k: key, v: value
            actors.forEach((k, v) -> b.append(v + ", "));
            movie += b.toString();
            // strip off last
            movie = movie.substring(0, movie.length() - 2);

            movieList.add(movie);
        }

        model.addAttribute("moviescount", service.getKey("moviescount"));
        model.addAttribute("movies", movieList);

        return "movies";

    }

    // get the add movie page
    @GetMapping("/addMovie")
    public String addMovie() {
        return "movieForm";
    }

    @PostMapping("/addMovie")
    public String saveMovie(@RequestParam("movieTitle") String title, @RequestParam("releaseYear") String year,
    @RequestParam("actor") String actor) {

        System.out.println(title);

        Map<String, String> actors = new HashMap<String, String>();
        actors.put("actor1", actor);
        service.hset("movies:" + year + ":" + title, actors);
        service.incr("moviescount");
        actors.clear();

        return "redirect:/movies";
    }
 }

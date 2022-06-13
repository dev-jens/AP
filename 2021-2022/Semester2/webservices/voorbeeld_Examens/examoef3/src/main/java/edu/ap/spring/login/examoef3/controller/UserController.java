package edu.ap.spring.login.examoef3.controller;

import java.nio.charset.StandardCharsets;
import java.security.MessageDigest;
import java.util.Set;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.ResponseBody;

import edu.ap.spring.login.examoef3.redis.RedisService;

@Controller
public class UserController {

    @Autowired
	private RedisService service;

    @GetMapping("/")
	private String getIndex() {
		return "redirect:/signup";
	}

    @GetMapping("/signup")
	private String signUp() {
		return "signup";
	}

    @ResponseBody
    @PostMapping("/signup")
	private String registerUser(@RequestParam("email") String email, @RequestParam("password") String password) {

        if(!service.exists("usercounter")) {
            service.incr("usercounter");
        }

        String userKey = "user:" + bytesToHex(email + password) + ":" + service.getKey("usercounter");
        
        if(!service.exists(userKey)) {
            service.setKey(userKey, email);
            service.incr("usercounter");
        }
        
        return "SINGED UP";
	}

    @GetMapping("/login")
	public String getLogin() {
		return "login";
	}

    @PostMapping("/login")
	@ResponseBody
	public String doLogin(@RequestParam("email") String email, @RequestParam("password") String password) {

        service.setBit("login", 1, true);
        String key = bytesToHex(email + password);
        Set<String> s = service.keys("user:" + key + ":*");
       
        if(s.isEmpty())
            return "NOT LOGGED IN";
        else
            return "LOGGED IN";
	}

    @GetMapping("/user/{userid}")
	@ResponseBody
	public String list(@PathVariable("userid") String userid) {
		
        Set<String> s = service.keys("user:*");
        for(String key : s) {
            String id = key.split(":")[2];
            if(userid.equals(id)) {
                System.out.println(key);
                return service.getKey(key);
            }
        }
        return "NOT FOUND";
	}

    private String bytesToHex(String str) {
		String retString = "";
		try {
			MessageDigest digest = MessageDigest.getInstance("SHA-256");
			byte[] encodedhash = digest.digest((str).getBytes(StandardCharsets.UTF_8));
			StringBuffer hexString = new StringBuffer();
			for (int i = 0; i < encodedhash.length; i++) {
				String hex = Integer.toHexString(0xff & encodedhash[i]);
				if (hex.length() == 1)
					hexString.append('0');
				hexString.append(hex);
			}
			retString = hexString.toString();
		} catch (Exception ex) {
			System.out.println(ex.getMessage());
		}

		return retString;
	}
    
}

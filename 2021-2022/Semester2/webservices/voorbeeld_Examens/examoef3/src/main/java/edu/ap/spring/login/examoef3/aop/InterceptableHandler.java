package edu.ap.spring.login.examoef3.aop;

import java.nio.charset.StandardCharsets;
import java.security.MessageDigest;
import java.util.Set;

import org.aspectj.lang.ProceedingJoinPoint;
import org.aspectj.lang.annotation.Around;
import org.springframework.beans.factory.annotation.Autowired;

import edu.ap.spring.login.examoef3.redis.RedisService;

public class InterceptableHandler {

    @Autowired
	private RedisService service;
    
    @Around("execution(public * doLogin(..))")
    public String aroundInterceptable(ProceedingJoinPoint joinPoint) throws Throwable{
        String result = joinPoint.proceed().toString();

        String email = joinPoint.getArgs()[0].toString();
        String password = joinPoint.getArgs()[1].toString();
        String hexcode =  bytesToHex(email + password);

        Set<String> keys = service.keys("*");
        for(String key : keys) {
            if(key.contains(hexcode)) {
               service.setBit(key, Integer.parseInt(key.split(":")[2]), true);
            }
        }
            

        return result;
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

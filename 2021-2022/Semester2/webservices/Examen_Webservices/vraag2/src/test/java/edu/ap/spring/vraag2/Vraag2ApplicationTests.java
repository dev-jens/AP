package edu.ap.spring.vraag2;

import org.junit.jupiter.api.*;
import static org.junit.jupiter.api.Assertions.*;
import org.springframework.boot.test.context.SpringBootTest;
import org.springframework.boot.test.web.client.TestRestTemplate;
import org.springframework.http.HttpEntity;
import org.springframework.http.HttpHeaders;
import org.springframework.http.MediaType;
import org.springframework.http.ResponseEntity;
import org.springframework.util.LinkedMultiValueMap;
import org.springframework.util.MultiValueMap;
import org.junit.jupiter.api.Test;

@SpringBootTest(webEnvironment = SpringBootTest.WebEnvironment.DEFINED_PORT)
class Vraag2ApplicationTests {

	@Test
	public void test1() throws Exception {
	  TestRestTemplate testRestTemplate = new TestRestTemplate();
	  HttpHeaders headers = new HttpHeaders();
	  headers.setContentType(MediaType.APPLICATION_FORM_URLENCODED);
	  MultiValueMap<String, String> map = new LinkedMultiValueMap<String, String>();
	  map.add("students", "s111;Matthias Schoenaerts;s222;Veerle Baetens;s333;Matteo Simoni;s444;Louis Talpe");
  
	  HttpEntity<MultiValueMap<String, String>> request = new HttpEntity<MultiValueMap<String, String>>(map, headers);
	  ResponseEntity<String> response1 = testRestTemplate.postForEntity("http://localhost:8080/importStudents", request , String.class);
  
	  ResponseEntity<String> response2 = testRestTemplate.getForEntity("http://localhost:8080/s222", String.class);
  
	  assertTrue(response2.getBody().contains("Veerle Baetens"));
	}
  
	@Test
	public void test2() throws Exception {
	  TestRestTemplate testRestTemplate = new TestRestTemplate();
	  ResponseEntity<String> response = testRestTemplate.getForEntity("http://localhost:8080/s444", String.class);
	
	  assertTrue(response.getBody().contains("Louis Talpe"));
	}
  
	@Test
	public void test3() throws Exception {
	  TestRestTemplate testRestTemplate = new TestRestTemplate();
	  HttpHeaders headers = new HttpHeaders();
	  headers.setContentType(MediaType.APPLICATION_FORM_URLENCODED);
	  MultiValueMap<String, String> map = new LinkedMultiValueMap<String, String>();
	  map.add("students", "s222;Veerle Baetens;s333;Matteo Simoni");
  
	  HttpEntity<MultiValueMap<String, String>> request = new HttpEntity<MultiValueMap<String, String>>(map, headers);
	  ResponseEntity<String> response = testRestTemplate.postForEntity("http://localhost:8080/importStudents", request , String.class);
  
	  assertTrue(response.getBody().contains("Student exists"));
	}

}

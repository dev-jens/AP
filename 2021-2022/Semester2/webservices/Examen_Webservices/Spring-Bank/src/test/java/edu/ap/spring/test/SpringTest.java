package edu.ap.spring.test;

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

@SpringBootTest(webEnvironment = SpringBootTest.WebEnvironment.DEFINED_PORT)
public class SpringTest {

  @Test
  public void test1() throws Exception {
	// https://www.baeldung.com/spring-boot-testresttemplate
 	TestRestTemplate testRestTemplate = new TestRestTemplate();
	ResponseEntity<String> response1 = testRestTemplate.getForEntity("http://localhost:8080/balance/walletA", String.class);
	ResponseEntity<String> response2 = testRestTemplate.getForEntity("http://localhost:8080/balance/walletB", String.class);
  
	assertTrue(response1.getBody().contains("50.0"));
	assertTrue(response2.getBody().contains("50.0"));
  }

  @Test
  public void test2() throws Exception {
	TestRestTemplate testRestTemplate = new TestRestTemplate();
	HttpHeaders headers = new HttpHeaders();
	headers.setContentType(MediaType.APPLICATION_FORM_URLENCODED);
	MultiValueMap<String, String> map = new LinkedMultiValueMap<String, String>();
	map.add("wallet1", "walletA");
	map.add("wallet2", "walletB");
	map.add("amount", "55.0");

	HttpEntity<MultiValueMap<String, String>> request = new HttpEntity<MultiValueMap<String, String>>(map, headers);
	ResponseEntity<String> response0 = testRestTemplate.postForEntity("http://localhost:8080/transaction", request , String.class);

	ResponseEntity<String> response1 = testRestTemplate.getForEntity("http://localhost:8080/balance/walletA", String.class);
	ResponseEntity<String> response2 = testRestTemplate.getForEntity("http://localhost:8080/balance/walletB", String.class);

	assertTrue(response0.getBody().contains("Not enough coins for transaction"));
	assertTrue(response1.getBody().contains("50.0"));
	assertTrue(response2.getBody().contains("50.0"));
  }

  @Test
  public void test3() throws Exception {
 	TestRestTemplate testRestTemplate = new TestRestTemplate();
	HttpHeaders headers = new HttpHeaders();
	headers.setContentType(MediaType.APPLICATION_FORM_URLENCODED);
	MultiValueMap<String, String> map = new LinkedMultiValueMap<String, String>();
	map.add("wallet1", "walletA");
	map.add("wallet2", "walletB");
	map.add("amount", "30.0");

	HttpEntity<MultiValueMap<String, String>> request = new HttpEntity<MultiValueMap<String, String>>(map, headers);
	testRestTemplate.postForEntity("http://localhost:8080/transaction", request, String.class);
  
	ResponseEntity<String> response1 = testRestTemplate.getForEntity("http://localhost:8080/balance/walletA", String.class);
	ResponseEntity<String> response2 = testRestTemplate.getForEntity("http://localhost:8080/balance/walletB", String.class);

  	assertTrue(response1.getBody().contains("20.0"));
	assertTrue(response2.getBody().contains("80.0"));
  }

  @Test
  public void test4() throws Exception {
 	TestRestTemplate testRestTemplate = new TestRestTemplate();
	HttpHeaders headers = new HttpHeaders();
	headers.setContentType(MediaType.APPLICATION_FORM_URLENCODED);
	MultiValueMap<String, String> map = new LinkedMultiValueMap<String, String>();
	map.add("wallet1", "walletB");
	map.add("wallet2", "walletA");
	map.add("amount", "20.0");

	HttpEntity<MultiValueMap<String, String>> request = new HttpEntity<MultiValueMap<String, String>>(map, headers);
	testRestTemplate.postForEntity("http://localhost:8080/transaction", request , String.class);
  
	ResponseEntity<String> response1 = testRestTemplate.getForEntity("http://localhost:8080/balance/walletA", String.class);
	ResponseEntity<String> response2 = testRestTemplate.getForEntity("http://localhost:8080/balance/walletB", String.class);

  	assertTrue(response1.getBody().contains("40.0"));
	assertTrue(response2.getBody().contains("60.0"));
  }
}

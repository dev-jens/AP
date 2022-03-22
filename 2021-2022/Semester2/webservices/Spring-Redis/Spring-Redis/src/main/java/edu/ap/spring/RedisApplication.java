package edu.ap.spring;

import java.util.HashMap;
import java.util.Map;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.CommandLineRunner;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.context.ApplicationContext;
import org.springframework.context.annotation.Bean;
import org.springframework.data.redis.connection.RedisConnectionFactory;
import org.springframework.data.redis.listener.ChannelTopic;
import org.springframework.data.redis.listener.RedisMessageListenerContainer;
import org.springframework.data.redis.listener.adapter.MessageListenerAdapter;
import edu.ap.spring.controller.RedisController;
import edu.ap.spring.redis.RedisService;

@SpringBootApplication
public class RedisApplication {
	
	private String CHANNEL = "edu:ap:redis";
	@Autowired
	private RedisService service;
	
	@Bean
	RedisMessageListenerContainer container(RedisConnectionFactory connectionFactory,
											MessageListenerAdapter listenerAdapter) {

		RedisMessageListenerContainer container = new RedisMessageListenerContainer();
		container.setConnectionFactory(connectionFactory);
		container.addMessageListener(listenerAdapter, new ChannelTopic(CHANNEL));

		return container;
	}

	@Bean
	MessageListenerAdapter listenerAdapter(RedisController controller) {
		return new MessageListenerAdapter(controller, "onMessage");
	}
	
	@Bean
  	public CommandLineRunner commandLineRunner(ApplicationContext ctx) {
		return (args) -> {

			// empty db
			this.service.flushDb();

			// messaging
	 		service.sendMessage(CHANNEL, "Hello from Spring Boot");
	 		
	 		// keys
	 		service.setKey("edu:ap:test", "Key from Spring Boot");
	 		System.out.println(service.getKey("edu:ap:test"));
	 		
	 		// bitops
	 		String bitKey = "edu:ap:bits";
	 		service.setBit(bitKey, 73, true);
	 		service.setBit(bitKey, 85, true);
	 		service.setBit(bitKey, 90, true);
	 		System.out.println(bitKey + ", bit 73 : " + service.getBit(bitKey, 73));
	 		System.out.println(bitKey + ", bit count : " + service.bitCount(bitKey));
	 		
			// movies
			this.service.setKey("moviescount", "0");
	 		Map<String, String> actors = new HashMap<String, String>();
	 		actors.put("actor1", "Jeff Bridges");
			actors.put("actor2", "John Goodman");
			actors.put("actor3", "John Turturro");
			actors.put("actor4", "Steve Buscemi");
	 		service.hset("movies:1998:The Big Lebowski", actors);
			service.incr("moviescount");
	 		actors.clear();
	 		actors.put("actor1", "Billy Bob Thornton");
			actors.put("actor2", "Tony Cox");
			actors.put("actor3", "Lauren Graham");
	 		service.hset("movies:2003:Bad Santa", actors);
			service.incr("moviescount");
			
			System.out.println("Total movies : " + service.getKey("moviescount"));
		};
  }
	
	public static void main(String[] args) {
		SpringApplication.run(RedisApplication.class, args);
	}
}

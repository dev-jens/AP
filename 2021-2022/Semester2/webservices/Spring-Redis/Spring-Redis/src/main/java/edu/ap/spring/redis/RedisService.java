package edu.ap.spring.redis;

import java.util.Map;
import java.util.Set;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.data.redis.connection.RedisConnection;
import org.springframework.data.redis.core.*;
import org.springframework.stereotype.Service;

@Service
public class RedisService {

	@Autowired
	private StringRedisTemplate stringTemplate;
	
	private RedisConnection getConnection() {
		return this.stringTemplate.getConnectionFactory().getConnection();
	}

	public void setKey(String key, String value) {
		this.stringTemplate.opsForValue().set(key, value);
	}

	public String getKey(String key) {
 		return this.stringTemplate.opsForValue().get(key);
	}

	public Set<String> keys(String pattern) {
		return this.stringTemplate.keys(pattern);
	}

	public void hset(String key, Map<String, String> values) {
		this.stringTemplate.opsForHash().putAll(key, values);
	}

	public Map<Object, Object> hgetAll(String key) {
		 return stringTemplate.opsForHash().entries(key);
	}
	
	public void sendMessage(String channel, String message) {
		this.stringTemplate.convertAndSend(channel, message);
	}

	// methods without template interface
	public Long incr(String key) {
		return this.getConnection().incr(key.getBytes());
	}

	public Boolean setBit(String key, int offset, boolean value) {
		return this.getConnection().setBit(key.getBytes(), offset, value);
	}
	
	public Boolean getBit(String key, int offset) {
		return this.getConnection().getBit(key.getBytes(), offset);
	}
	
	public Long bitCount(String key) {
		return this.getConnection().bitCount(key.getBytes());
	}
	
	public void flushDb() {
		this.getConnection().flushDb();
	}
}

/*
 // ValueOperations, BoundValueOperations
stringTemplate.opsForValue().set(key, value); 
stringTemplate.boundValueOps(key).set(value); 

// HashOperations, BoundHashOperations
stringTemplate.opsForHash().put(key, "hashKey", value); 
stringTemplate.boundHashOps(key).put("hashKey", value); 

// ListOperations, BoundListOperations
stringTemplate.opsForList().leftPush(key, value); 
stringTemplate.opsForList().rightPush(key, value); 
stringTemplate.opsForList().rightPop(key, 1, TimeUnit.SECONDS); 
stringTemplate.opsForList().leftPop(key, 1, TimeUnit.SECONDS); 
stringTemplate.boundListOps(key).leftPush(value); 
stringTemplate.boundListOps(key).rightPush(value); 
stringTemplate.boundListOps(key).rightPop(1, TimeUnit.SECONDS); 
stringTemplate.boundListOps(key).leftPop(1, TimeUnit.SECONDS); 

// ZSetOperations, BoundZSetOperations
stringTemplate.opsForZSet().add(key, "player1", 12.0d); 
stringTemplate.opsForZSet().add(key, "player2", 11.0d); 
stringTemplate.boundZSetOps(key).add("player1", 12.0d); 
stringTemplate.boundZSetOps(key).add("player2", 11.0d);

// Misc
stringTemplate.getConnectionFactory().getConnection().bitOp(BitOperation.AND, arg1, arg2);
stringTemplate.expire(key, 1, TimeUnit.SECONDS);
stringTemplate.opsForHyperLogLog().add(arg0, arg1);
*/

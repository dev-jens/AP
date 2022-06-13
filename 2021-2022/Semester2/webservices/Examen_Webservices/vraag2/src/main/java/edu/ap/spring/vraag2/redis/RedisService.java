package edu.ap.spring.vraag2.redis;

import java.util.Map;
import java.util.Set;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.data.redis.connection.RedisConnection;
import org.springframework.data.redis.core.StringRedisTemplate;
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

	public Boolean exists(String key) {
		return this.stringTemplate.hasKey(key);
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
	public int incr(String key) {
		if (this.exists(key)) {
			this.getConnection().incr(key.getBytes());
		} else {
			this.setKey(key, "1");
		}
		return Integer.parseInt(this.getKey(key));
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
    

package labo6.javadocs;

import java.util.ArrayList;
import java.util.LinkedHashSet;
import java.util.List;

/*
 * # Oef Coll.2 Deze oefening helpt met het inzicht verwerven dat generieke
 * klassen nuttig kunnen zijn. Maak een generieke klasse `KeyValues` die
 * zogenaamde [key-value
 * pairs](https://en.wikipedia.org/wiki/Key-value_database) bijhoudt.
 * Initialisatie gebeurt in de klasse door middel van twee collecties. Een
 * getter geeft de value terug op basis van een key. Denk na over de toegelaten
 * types.

 */

/***
 *
 * @author Baeten jens
 * @version 0.0.1
 * @since 29/12/2021
 */

public class KeyValues<E, T> {

	LinkedHashSet<E> keys;
	List<T> values;


	public KeyValues() {
		this.keys = new LinkedHashSet<>();
		this.values = new ArrayList<>();
	}

	/**
	 *
	 * @param key this is the key og the linkedHashset
	 * @param value this is the value that will be shown at the key
	 * @return boolean if does not exists student will be added and you will get true otherwise it will return false
	 */
	public Boolean addValue(E key, T value) {
		if (key != null) {
			if (this.keys.add(key)) {
				this.values.add(value);
				return true;
			}
		}
		return false;
	}

	/**
	 * add a value
	 * @param key this is the key og the linkedHashset
	 * @param value this is the value that will be shown at the key
	 * @return bool if value is over written
	 */
	public Boolean addValueOverride(E key, T value) {
		if (key != null) {
			if (this.keys.add(key)) {
				this.values.add(value);
				return true;
			} else {
				Integer index = findIndex(key);
				if(index != null) {
					values.set(index, value);
					return true;
				}
			}
		}

		return false;

	}

	private Integer findIndex(E key) {
		int count = 0;
		for (E item : keys) {
			if (item.equals(key)) {
				return count;
			}
			count++;
		}
		return null;
	}

	public T getValue(E key) {
		Integer index = findIndex(key);
		if (index != null) {
			return values.get(index);
		}
		return null;
	}

	@Override
	public String toString() {
		return "KeyValues [keys=" + keys + ", values=" + values + "]";
	}

}

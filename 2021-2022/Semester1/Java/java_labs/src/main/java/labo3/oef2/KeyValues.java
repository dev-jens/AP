package labo3.oef2;

import java.util.LinkedHashSet;
import java.util.LinkedList;
import java.util.List;
import java.util.Set;

public class KeyValues<T> {

    private Set<T> key;
    private List<T> value;
    public int size;


    public KeyValues() {
        this.key = new LinkedHashSet<>();
        this.value = new LinkedList<>();
    }
    public void addValue(T _key , T _value){
        key.add(_key);
        int index = getIndex(_key);
        this.value.add(index,_value);
        size++;
    }
    private int getIndex(T key){
        int index = 0;
        for (T s : this.key) {
            if (s.equals(key))
                break;
            index++;
        }
        return index;
    }
    public T getValue(T key){
        int index = getIndex(key);
        return value.get(index);
    }
    public void RemoveVal(T key){
        int index = getIndex(key);
        this.key.remove(key);
        this.value.remove(index);
    }

    @Override
    public String toString() {
        return "KeyValues{" +
                "key=" + key +
                ", Value=" + value +
                '}';
    }


}

package Lab3.oef2;

import java.util.*;

public class KeyValues<T> {
     private Set<T> key;
     private List<T> Value;
     public int size;

    public KeyValues() {
        this.key = new LinkedHashSet<>();
        this.Value = new LinkedList<>();
    }
    public void addValue(T _key , T _value){
        this.key.add(_key);
        int index = getIndex(_key);
        this.Value.add(index,_value);
        size++;
    }
    private int getIndex(T key){
        int index = 0;
        for (T s : this.key) {
            if (s.equals(this.key))
                break;
            index++;
        }
        return index;
    }
    public T getValue(T key){
        int index = getIndex(key);
        return Value.get(index);
    }
    public void RemoveVal(T key){
        int index = getIndex(key);
        this.key.remove(key);
        this.Value.remove(index);
    }

    @Override
    public String toString() {
        return "KeyValues{" +
                "key=" + key +
                ", Value=" + Value +
                '}';
    }

}

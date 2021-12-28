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


}

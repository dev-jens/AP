package Lab3.oef5;

import java.util.HashSet;
import java.util.Set;

public class Main {
    public static void main(String[] args) {
        Set<String> hash_Set = new HashSet<String>();

        // Adding elements to the Set
        // using add() method
        hash_Set.add("jens");
        hash_Set.add("niet jens");
        hash_Set.add("jens");


        // Printing elements of HashSet object
        System.out.println(hash_Set);

    }
}

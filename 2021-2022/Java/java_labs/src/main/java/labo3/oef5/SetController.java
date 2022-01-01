package labo3.oef5;

import java.util.HashMap;
import java.util.HashSet;
import java.util.Set;

public class SetController {
    public static void main(String[] args) {

        HashSet<String> uniqueNames = new HashSet<>();
        HashMap<Integer , String> dict = new HashMap<>();
        dict.put(1,"jens");
        dict.put(2,"jens");
        // overschrijft jens
        dict.put(1,"JCVD");



        uniqueNames.add("jens");
        uniqueNames.add("jens");
        uniqueNames.add("olaf");

        System.out.println(dict);
        System.out.print(uniqueNames);
    }
}

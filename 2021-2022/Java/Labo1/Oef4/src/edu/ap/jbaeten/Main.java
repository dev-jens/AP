package edu.ap.jbaeten;

public class Main {

    public static void main(String[] args) {
        Drank water = new Drank(1.5 , "water");
        AlcolischeDranken whiskey = new AlcolischeDranken(19.99, "whiskey", 7.4);
        NonAlcolischeDranken cola = new NonAlcolischeDranken(2.3, "cola", true);

        System.out.println(water);
        System.out.println(whiskey);
        System.out.println(cola);
    }
}

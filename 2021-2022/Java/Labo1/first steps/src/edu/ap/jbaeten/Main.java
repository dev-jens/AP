package edu.ap.jbaeten;

public class Main {

    public static void main(String[] args) {
	    System.out.println("hello world");
        Persoon jens = new Persoon();
        jens.SetName("jens");
        System.out.println(jens.GetName());
        System.out.println(jens);
    }
}

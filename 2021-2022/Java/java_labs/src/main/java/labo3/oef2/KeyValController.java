package labo3.oef2;

public class KeyValController {

    public static void main(String[] args) {

        KeyValues<String> values = new KeyValues<>();

        values.addValue("test1","helloWorld1");
        values.addValue("test2","helloWorld2");
        values.addValue("test3","helloWorld3");
        values.addValue("test4","helloWorld4");

        System.out.println(values);

    }
}

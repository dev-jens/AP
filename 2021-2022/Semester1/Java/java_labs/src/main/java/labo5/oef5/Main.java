package labo5.oef5;

public class Main {
    public static void main(String[] args) {
        System.out.println(febonacci(3));
    }

    static int febonacci (int getal){

        if (getal <= 1)
            return 1;

        return febonacci(getal -1 ) + febonacci(getal -2);
    }
}

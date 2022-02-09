package lab5.oef3;

public class Main {
    public static void main(String[] args) {
        System.out.println(numberOfDigits(1));
        System.out.println(numberOfDigits(10));
        System.out.println(numberOfDigits(100));
        System.out.println(numberOfDigits(1000));
        System.out.println(numberOfDigits(10000));

    }

    static int numberOfDigits(int n){
        if( n < 10)
            return 1;

        return 1 + numberOfDigits(n/10);
    }

}

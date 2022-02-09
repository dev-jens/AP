package labo5.oef1;

public class demoCodeTester {
    public static void main(String[] args) {

        System.out.println(gcd(10,12));

    }

    static int gcd(int a , int b ){
        if (b==0)
            return a;
        return gcd(b,a%b);


    }
}

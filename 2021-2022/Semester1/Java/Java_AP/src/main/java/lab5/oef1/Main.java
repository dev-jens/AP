package lab5.oef1;

public class Main {
    public static void main(String[] args) {
        System.out.println(gcd(20, 12)); //4
    }
    static int gcd(int a, int b){
        if (b == 0){
            return a;
        }
        return gcd(b, a % b);
    }
}

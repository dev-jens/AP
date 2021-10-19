package lab5.oef5;

public class Main {
    public static void main(String[] args) {
        doFibonacci(5);
    }

    static int doFibonacci(int n){
        if(n <= 1)
            return n;

        return doFibonacci(n-1) + doFibonacci(n-2);
    }
}

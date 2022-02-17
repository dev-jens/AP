package lab5.oef2;

public class Main {
    public static void main(String[] args) {
        countDown(5);
    }
    static void countDown(int len){
        if (len == 0){
            System.out.println("Take Off !");
            return;
        }
        System.out.println(len);
        countDown(len - 1);

    }
}

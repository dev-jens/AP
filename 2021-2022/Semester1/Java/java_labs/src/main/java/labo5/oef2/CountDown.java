package labo5.oef2;

public class CountDown {

    public static void main(String[] args) {
        CountDownRaket(10);
    }

    static void CountDownRaket(int len){

        if(len == 0){
            System.out.println("Take Off");
            return;
        }

        System.out.println(len);
        CountDownRaket(len - 1);

    }
}

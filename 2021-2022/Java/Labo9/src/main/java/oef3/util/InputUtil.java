package oef3.util;

import java.util.Scanner;

public class InputUtil {

    private final Scanner scanner;

    public InputUtil() {
        this.scanner = new Scanner(System.in);
    }
    public void start(){
        scanner.reset();
    }
    public String next(){
        return scanner.next();
    }

}

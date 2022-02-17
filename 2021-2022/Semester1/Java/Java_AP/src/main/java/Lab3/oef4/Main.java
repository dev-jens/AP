package Lab3.oef4;

public class Main {
    public static void main(String[] args) {
        ArrayLIFOQueue<Integer> array = new ArrayLIFOQueue<Integer>();

        for (int i = 0; i < 11; i++) {
            array.push(i);
        }

        System.out.print("ISEMPTY? : " + array.isEmpty() + "\n");
        System.out.print("PEEK: " + array.peek() + "\n");

        for (int i = 0; i < 10; i++) {
            array.pop();
        }

        System.out.print("10de pop: " + array.pop() + "\n");
        System.out.print("ISEMPTY? : " + array.isEmpty() + "\n");
    }
}

package Lab3.oef4;

import java.util.ArrayDeque;

public class ArrayLIFOQueue<T> implements LIFOQueue<T>{

    ArrayDeque<T> array= new ArrayDeque();
    @Override
    public Boolean isEmpty() {
        return array.isEmpty();
    }
    @Override
    public void push(T item) {
        array.push(item);
    }
    @Override
    public T pop() {
        return array.pop();
    }
    @Override
    public T peek() {
        return array.peek();
    }
}

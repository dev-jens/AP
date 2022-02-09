package labo3.oef4;

import java.util.ArrayDeque;

public class ArrayLIFOQueue<T> implements LIFOQueue<T>{

    ArrayDeque<T> arrayDeque = new ArrayDeque<>();

    @Override
    public Boolean isEmpty() {
        if (arrayDeque.isEmpty())
            return true;
        return false;
    }

    @Override
    public void push(T item) {
        arrayDeque.addFirst(item);

    }

    @Override
    public T pop() {
        return arrayDeque.pollFirst();
    }

    @Override
    public T peek() {
        return arrayDeque.peekFirst();
    }
}


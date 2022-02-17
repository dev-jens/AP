package Lab3.oef4;

public interface LIFOQueue<T> {
    Boolean isEmpty();
    void push(T item);
     T pop();
     T peek();
}

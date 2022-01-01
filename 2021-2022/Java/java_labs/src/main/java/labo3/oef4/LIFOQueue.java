package labo3.oef4;

public interface LIFOQueue<T> {

    public Boolean isEmpty();
    public void push(T item);
    public T pop();
    public T peek();
}

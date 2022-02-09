package testing;

public class calculator {
    int memory = 0;
    public int add(int a , int b){
        memory = a+b;
        return a+b;
    }

    public int addresult(int i) {
        memory += i;
        return memory;
    }
}

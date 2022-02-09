package testing;

abstract class animal {

    abstract void maakgeluid();
    abstract int aantalpoten(int poten);

    public void helpkreet(){
        System.out.println("help");
    }
    public int aantalogen(int ogencount){
        return ogencount;
    }
}

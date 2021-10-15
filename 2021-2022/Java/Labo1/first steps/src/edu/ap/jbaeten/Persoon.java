package edu.ap.jbaeten;

public class Persoon {

    private String Name;

    // getter Name
    public String GetName(){
        return this.Name;
    }
    //setter Name
    public void SetName(String Name){
        this.Name = Name;
    }

    @Override
    public String toString() {
        return "Persoon{" +
                "Name=' " + Name + '\'' +
                '}';
    }
}

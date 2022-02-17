package Lab3.oef1;

import java.util.ArrayList;
import java.util.Random;

public class Main {
    public static void main(String[] args) {
        ArrayList<Character> characterList =  new ArrayList<Character>();

        characterList.add(new Character("Rick","Sanchez"));
        characterList.add(new Character("Beth","Sanchez"));
        characterList.add(new Character("jerry","Smith"));
        characterList.add(new Character("Morty","Smith"));
        characterList.add(new Character("Squanshy","?"));
        characterList.add(new Character("Bird","Person"));

        System.out.print("ORIGINAL:");
        System.out.println(characterList + "\n");

        Remove(characterList, 2);
        System.out.print("DELETED:");
        System.out.println(characterList);
    }
    static void Remove(ArrayList list ,int amount ){
        Random r = new Random();

        if (list.size() < amount){
            amount = list.size();
        }

        for (int i = 0; i < amount; i++) {
            int ranInt = r.nextInt(amount);
            list.remove(i);
        }
    }
}

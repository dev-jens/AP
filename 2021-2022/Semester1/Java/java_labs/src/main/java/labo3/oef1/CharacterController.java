package labo3.oef1;

import java.util.ArrayList;
import java.util.LinkedList;
import java.util.Random;

public class CharacterController {
    public static void main(String[] args) {

        ArrayList<Character> characterArrayList =  new ArrayList<>();
        characterArrayList.add(new Character("Rick","Sanchez"));
        characterArrayList.add(new Character("Beth","Sanchez"));
        characterArrayList.add(new Character("jerry","Smith"));
        characterArrayList.add(new Character("Morty","Smith"));
        characterArrayList.add(new Character("Squanshy","?"));
        characterArrayList.add(new Character("Bird","Person"));


        LinkedList<Character> characterLinkedList = new LinkedList<>();
        characterLinkedList.add(new Character("Rick","Sanchez"));
        characterLinkedList.add(new Character("Beth","Sanchez"));
        characterLinkedList.add(new Character("jerry","Smith"));
        characterLinkedList.add(new Character("Morty","Smith"));
        characterLinkedList.add(new Character("Squanshy","?"));
        characterLinkedList.add(new Character("Bird","Person"));


        Random r = new Random();
        int totalDeaths = r.nextInt(characterArrayList.size() + 1);

        for (int i = 0; i < totalDeaths; i++) {

            int deleted  = r.nextInt(characterArrayList.size());
            System.out.println("index:"+ deleted +  "\nremoving " + characterArrayList.get(deleted));
            characterArrayList.remove(deleted);
        }

        for (int i = 0; i < characterArrayList.size(); i++) {

            System.out.println(characterArrayList.get(i));
        }









    }
}

package labo7;


import java.io.File;
import java.io.IOException;
import java.nio.charset.Charset;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.util.*;
import java.util.stream.Collectors;

public class Main {

    public static void main(String[] args) {

        List<Person> lecturersList = new ArrayList<>();
        lecturersList.add(new Person("jens", "baeten", "s118674@ap.be"));
        lecturersList.add(new Person("Jean-Claude", "Van damme", "JCVD@ap.be"));
        lecturersList.add(new Person("Rick", "Sanchez", "GOD@ap.be"));

        String fileName = "src\\main\\java\\resources\\four-letter-words.txt";


        // oefening 1
        System.out.println("oefening 1");
        List<String> names = Arrays.asList("peter", "anna", "mike", "xenia");
        Collections.sort(names, (a, b) -> a.compareTo(b));
        System.out.println(names);
        System.out.println("------------------------");


        // oefening 2
        System.out.println("oefening 2");
        //TODO: oef 2
        System.out.println("------------------------");


        //oefening 3
        System.out.println("oefening 3 ");
        lecturersList
                .stream()
                .filter(p -> p.getFirstName().equals("jens")) // filteren op naam
                .map(p -> p.getEmail()) // aanpasing aan de array nu willen we enkel de mail bekijken
                .forEach(System.out::println);
        System.out.println("------------------------");


        //oefening 4
        System.out.println("oefening 4 ");
        lecturersList
                .stream()
                .filter(p -> p.getEmail().equals("GOD@ap.be"))
                .map(person ->  person.getFirstName() + " " + person.getLastName())
                .forEach(System.out::println);
        System.out.println("------------------------");

        //oefening 5
        System.out.println("oefening 5 ");
        List<Person> personList = lecturersList
                .stream()
                .filter(p -> p.getEmail().equals("GOD@ap.be"))
                .collect(Collectors.toList());
        personList.forEach(p -> System.out.println(p.getFirstName()));
        System.out.println("------------------------");

        //oefening 6
        System.out.println("oefening 6 ");
        Person person = lecturersList
                .stream()
                .filter(p -> p.getEmail().equals("GOD@ap.be") && p.getFirstName()== "Rick")
                .findAny()
                .orElse(null);
        System.out.println(person.getFirstName());
        System.out.println("------------------------");

        // oefening 7
        System.out.println("oefening 7 ");
        String newFileName1 = "src\\main\\java\\resources\\four-letter-words-filtered.txt";
        Path newPath1 = Paths.get(newFileName1);

        try {
            List<String> newList1 = Files.lines(Paths.get(fileName))
                    .filter(l -> l.contains("AA"))
                    .peek(System.out::println)
                    .collect(Collectors.toList());
            Files.write(newPath1, newList1, Charset.defaultCharset());
            System.out.println("");
        }
        catch (IOException e) {
            e.printStackTrace();
        }
        System.out.println("------------------------");

        // oefening 8
        System.out.println("oefening 8");
        String newFileName3 = "src\\main\\java\\resources\\four-letter-words-filtered-on-palindrome.txt";
        Path newPath3 = Paths.get(newFileName3);

        try {
            List<String> newList3 = Files.lines(Paths.get(fileName))
                    .filter(s -> s.equals(new StringBuilder(s).reverse().toString()))
                    .peek(System.out::println)
                    .collect(Collectors.toList());
            Files.write(newPath3, newList3, Charset.defaultCharset());
            System.out.println("");
        }
        catch (IOException e) {
            e.printStackTrace();
        }

        // oefening 9
        System.out.println("oefening 9");
        List<City> cities = new ArrayList<>();
        cities.add(new City("New York",8550405, 86443));
        cities.add(new City("Boston",754987, 3864));
        cities.add(new City("Los Angeles",5439768, 1043));
        cities.add(new City("Chicago",2720546, 87));
        cities.add(new City("San Diego",1394928, 86443));

        cities
                .stream()
                .filter(c -> c.getNrOfPeople() > 4000000 && c.getNrOfCrimes() < 8000 )
                .map(c -> c.getName())
                .forEach(System.out::println);
        System.out.println("");





    }
}

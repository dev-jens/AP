package labo3.oef3;

import java.util.Arrays;
import java.util.List;
import java.util.TreeSet;

public class BookController {
     public static void main(String[] args) {

          List<Book> marcDeBel = Arrays.<Book>asList(
                  new Book("De monsters van Frankenzwein", "Mark de Bel",1996,true),
                  new Book("De fautenkampioene", "Mark de Bel",1997,true),
                  new Book("Kikker", "Mark de Bel",2003,true),
                  new Book("Herfst", "Mark de Bel",2004,true),
                  new Book("Kadodder", "Mark de Bel",2013,true));

          List<Book> jkRowling = Arrays.<Book>asList(
                  new Book("Harry Potter and the Philosopher's Stone ", "JK Rowling",1997,true),
                  new Book("Harry Potter and the Chamber of Secrets ", "JK Rowling",1998,true),
                  new Book("Harry Potter and the Goblet of Fire", "JK Rowling",2000,true),
                  new Book("Harry Potter and the Order of the Phoenix", "JK Rowling",2003,true),
                  new Book("Harry Potter and the Deathly Hallows ", "JK Rowling",2007,true));


          List<Book> hermanBrusselmans = Arrays.<Book>asList(
                  new Book("Zul je mij altijd graag zien?", "Herman Brusselmans",1997,true),
                  new Book("De Kus in de Nacht ", "Herman Brusselmans",2002,true),
                  new Book("Mijn haar is lang ", "Herman Brusselmans",2009,true),
                  new Book("System.out.println(publisher)an drie tot zes ", "Herman Brusselmans",2011,true),
                  new Book("Mogelijke memoires", "Herman Brusselmans",2013,true));


          TreeSet<Book> pubs = new TreeSet<>();
          pubs.addAll(marcDeBel);
          pubs.addAll(jkRowling);
          pubs.addAll(hermanBrusselmans);

          TreeSet<Book> pubOnYear = new TreeSet<>(new SortByYear());
          pubOnYear.addAll(pubs);

          System.out.println("Sorted on Tittle");
          pubs.forEach(book -> System.out.println(book));
          System.out.println("Sorted on Year");
          pubOnYear.forEach(book -> System.out.println(book));
     }
}

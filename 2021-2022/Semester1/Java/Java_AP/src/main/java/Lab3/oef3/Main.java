package Lab3.oef3;

import java.util.ArrayList;
import java.util.Collections;

public class Main {
    public static void main(String[] args) {
        ArrayList<Book> stephenKingBooks = new ArrayList<>();
        ArrayList<Book> author1Books = new ArrayList<>();
        ArrayList<Book> author2Books = new ArrayList<>();

        stephenKingBooks.add(new Book("IT", "Stephen King", 1986, false));
        stephenKingBooks.add(new Book("De beproeving", "Stephen King", 1978, false));
        stephenKingBooks.add(new Book("The Shining", "Stephen King", 1977, true));
        stephenKingBooks.add(new Book("Carrie", "Stephen King", 1974, false));
        stephenKingBooks.add(new Book("Misery", "Stephen King", 1987, false));

        for (int i = 0; i < 5; i++) {
            author1Books.add(new Book(Integer.toString(i), "author1", 2000+i, false));
            author2Books.add(new Book(Integer.toString(i), "author2", 2002+i, false));
        }

        ArrayList<Book> allBooks = new ArrayList<Book>();
        allBooks.addAll(stephenKingBooks);
        allBooks.addAll(author1Books);
        allBooks.addAll(author2Books);

        System.out.print("UNSORTED: \n" + allBooks + "\n");

        Collections.sort(allBooks, new SortByTitle());
        System.out.print("SORTED BY TITLE: \n" + allBooks + "\n");

        Collections.sort(allBooks, new SortByYear());
        System.out.print("SORTED BY YEAR: \n" + allBooks + "\n");
    }
}

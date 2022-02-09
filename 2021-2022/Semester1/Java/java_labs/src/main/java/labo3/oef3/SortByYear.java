package labo3.oef3;

import java.util.Comparator;

public class SortByYear implements Comparator<Book> {
    @Override
    public int compare(Book o1, Book o2) {
        return o1.getReleaseYear().compareTo(o2.getReleaseYear());
    }
}

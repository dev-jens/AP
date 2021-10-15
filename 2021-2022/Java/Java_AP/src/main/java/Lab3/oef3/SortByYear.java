package Lab3.oef3;

import java.util.Comparator;

public class SortByYear implements Comparator<Book> {

    @Override
    public int compare(Book o1, Book o2) {
        return Integer.compare(o1.getReleaseYear(), o2.getReleaseYear());
    }
}

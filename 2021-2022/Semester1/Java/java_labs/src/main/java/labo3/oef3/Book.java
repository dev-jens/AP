package labo3.oef3;

import java.util.Objects;
import java.util.TreeSet;

public class Book implements Comparable<Book> {

    private String title;
    private String author;
    private Integer releaseYear;
    private Boolean hardCover;

    public Book(String title, String author, Integer releaseYear, Boolean hardCover) {
        this.title = title;
        this.author = author;
        this.releaseYear = releaseYear;
        this.hardCover = hardCover;
    }

    public String getTitle() {
        return title;
    }

    public void setTitle(String title) {
        this.title = title;
    }

    public String getAuthor() {
        return author;
    }

    public void setAuthor(String author) {
        this.author = author;
    }

    public Integer getReleaseYear() {
        return releaseYear;
    }

    public void setReleaseYear(Integer releaseYear) {
        this.releaseYear = releaseYear;
    }

    public Boolean getHardCover() {
        return hardCover;
    }

    public void setHardCover(Boolean hardCover) {
        this.hardCover = hardCover;
    }

    @Override
    public int compareTo(Book o) {
        return this.title.compareTo(o.title);
    }


    @Override
    public String toString() {
        return "Book{" +
                "title='" + title + '\'' +
                ", author='" + author + '\'' +
                ", releaseYear=" + releaseYear +
                ", hardCover=" + hardCover +
                '}';
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (!(o instanceof Book)) return false;
        Book book = (Book) o;
        return title.equals(book.title) && author.equals(book.author) && releaseYear.equals(book.releaseYear) && hardCover.equals(book.hardCover);
    }

    @Override
    public int hashCode() {
        return Objects.hash(title, author, releaseYear, hardCover);
    }



}

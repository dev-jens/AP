package Lab3.oef3;

import java.util.Objects;

public class Book {
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
        if (o == null || getClass() != o.getClass()) return false;
        Book book = (Book) o;
        return getTitle().equals(book.getTitle()) && getAuthor().equals(book.getAuthor()) && getReleaseYear().equals(book.getReleaseYear()) && getHardCover().equals(book.getHardCover());
    }

    @Override
    public int hashCode() {
        return Objects.hash(getTitle(), getAuthor(), getReleaseYear(), getHardCover());
    }
}

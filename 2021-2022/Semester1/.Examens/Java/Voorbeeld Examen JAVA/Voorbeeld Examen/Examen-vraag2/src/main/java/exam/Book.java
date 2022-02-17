package exam;

import java.util.Locale;
import java.util.Objects;

public class Book implements Comparable<Book>{

	private String title;
	private String author;
	private int releaseYear;

	public Book(String title, String author, int releaseYear) {
		super();
		this.title = title;
		this.author = author;
		this.releaseYear = releaseYear;
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

	public int getReleaseYear() {
		return releaseYear;
	}

	public void setReleaseYear(int releaseYear) {
		this.releaseYear = releaseYear;
	}

	@Override
	public String toString() {
		return "Book [title=" + title + ", author=" + author + ", releaseYear=" + releaseYear + "]";
	}

	@Override
	public boolean equals(Object o) {
		if (this == o) return true;
		if (!(o instanceof Book)) return false;
		Book book = (Book) o;
		return getReleaseYear() == book.getReleaseYear() && getTitle().equals(book.getTitle()) && getAuthor().equals(book.getAuthor());
	}

	@Override
	public int hashCode() {
		return Objects.hash(getTitle(), getAuthor(), getReleaseYear());
	}

	@Override
	public int compareTo(Book o) {
		return this.title.toLowerCase().compareTo(o.getTitle().toLowerCase());
	}
}

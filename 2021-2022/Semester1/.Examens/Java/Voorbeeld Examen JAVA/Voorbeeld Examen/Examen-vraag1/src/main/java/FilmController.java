import dao.FilmDao;
import entity.Film;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;
import java.io.IOException;
import java.util.Scanner;

public class FilmController {

    public static void main(String[] args) {

        FilmDao filmDao = loadFilms();
        System.out.println("press 1 to search on year, press 2 to search on title");
        int input = Integer.parseInt(readInput());

        switch(input) {
            case 1:
                try{
                    System.out.println("give the year you want to search");
                    int year = Integer.parseInt(readInput());
                    filmDao.searchByYear(year);
                }catch (NumberFormatException e){
                    System.out.println(e.getMessage() + " is not a number, Please enter a valid number");
                }
                break;
            case 2:
                System.out.println("give the Title you want to search");
                String title = readInput();
                filmDao.searchByTitle(title);
                break;
            default:
                System.out.println("No such option try again");
        }

    }


    public static FilmDao loadFilms() {
        FilmDao filmDao = new FilmDao();
        try {
            File file = new File("netflix_titles.csv");
            FileReader fr = new FileReader(file);
            BufferedReader br = new BufferedReader(fr);
            String line;
            int num = 0;
            while ((line = br.readLine()) != null) {
                String[] lines = line.split(";");
                if (num > 0 && lines.length >  11 && lines[1].equals("Movie")) {
                    filmDao.saveFilm(new Film(Integer.parseInt(lines[0]), lines[2], lines[3], lines[5], Integer.parseInt(lines[7]), lines[11]));
                }
                num++;
            }
            System.out.println(filmDao.getFilms().size());
            br.close();
        } catch (IOException ioe) {
            ioe.printStackTrace();
        }

        return filmDao;
    }

    static String readInput(){
        Scanner obj = new Scanner(System.in);
        return obj.nextLine() ;
    }
}


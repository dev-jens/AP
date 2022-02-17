package labo6;

import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;

public class main {
    public static void main(String[] args) {
        String filePath = "C:/Users/Eigenaar/Desktop/AP/2021-2022/Java/Java_AP/src/main/java/labo6/pizza-list.csv";

        try {
            FileReader reader = new FileReader(filePath);
            BufferedReader br = new BufferedReader(reader);
            String line = br.readLine();
            while(line != null){
                String[] splitedElem =  line.split(";");

                for (int i = 0; i < splitedElem.length; i++) {

                    // euro regex
                    splitedElem[1] = splitedElem[1].replaceAll("€" , "");


                    splitedElem[3] = splitedElem[3].replaceAll("en", ",");
                    splitedElem[3] = splitedElem[3].replaceAll("&", "");
                    if (i == 3){
                        for (int j = 0; j < splitedElem[3].length(); j++) {
                            System.out.print("");
                        }
                    }


                    System.out.print(splitedElem[i] + " ");
                }
                System.out.println();
                line = br.readLine();
            }
            br.close();

        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }


    }

}

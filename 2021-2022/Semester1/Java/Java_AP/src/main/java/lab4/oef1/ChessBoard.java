package lab4.oef1;

import java.security.spec.RSAOtherPrimeInfo;

public class ChessBoard {

    int size = 4 ;

    public ChessBoard(int size) {
        this.size = size;
    }

    public void createBoard(){

        for (int i = 0; i < this.size; i++) {
            for (int j = 0; j < this.size; j++) {
                int cell = (i+j)%2;
                if(cell == 0)
                    System.out.printf("%c", 0x25A0);
                else
                    System.out.printf("%c", 0x25A1);
            }
            System.out.println();
        }


    }
}

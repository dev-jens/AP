package labo4.oef1;

public class Chessboard {
    private int size;
    private  char[][] board;

    public Chessboard(int size) {
        this.size = size;
        generateBoard();
    }

    private void generateBoard(){
        board = new char[size][size];
        Boolean useFull = false;
        for (int i = 0; i < size; i++) {
            for (int j = 0; j < size; j++) {
                if (useFull)
                    board[i][j] = '\u25A0';
                else
                    board[i][j] = '\u25A1';
                useFull = !useFull;
            }
            useFull = !useFull;
        }
    }

    public void print() {
        for(int i =0 ; i< size ; i++){
            for(int j =0 ; j< size ; j++){
                System.out.print(board[i][j] + " ");
            }

            System.out.println();
        }
    }
}

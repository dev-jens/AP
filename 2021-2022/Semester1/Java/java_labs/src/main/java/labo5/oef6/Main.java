package labo5.oef6;

public class Main {
    public static void main(String[] args) {

    }

    static int totalConsonants(String str, int n)
    {
        if (n == 1)
        {
            if(isConsonant(str.charAt(0)))
                return 1;
            else
                return 0;
        }
        if(isConsonant(str.charAt(n - 1)))
            return totalConsonants(str, n - 1) + 1;
        else
            return totalConsonants(str, n - 1);
    }


    static int totalConsonantsIterative(String str)
    {
        int count = 0;
        for (int i = 0; i < str.length(); i++)
            if (isConsonant(str.charAt(i)))
                ++count;
        return count;
    }


    static Boolean isConsonant(char ch){
        ch = Character.toUpperCase(ch);

        return (ch == 'A' || ch == 'E' ||
                ch == 'I' || ch == 'O' ||
                ch == 'U') && ch >= 65 && ch <= 90;
    }
}

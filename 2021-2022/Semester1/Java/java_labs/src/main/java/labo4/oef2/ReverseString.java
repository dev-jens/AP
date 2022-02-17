package labo4.oef2;

public class ReverseString {

    public static void main(String[] args) {


        String str = "wubba lubba dub dub ";

        System.out.println(ReverseLoop(str));
    }

    static String ReverseLoop(String str){
        String reverseString = "" ;

        for (int i = str.length(); i  > 0 ; i--) {
            reverseString += str.charAt(i - 1);

        }
        return reverseString;
    }
    static String CharReverse(String str){
        char[] reversedChar = new char[str.length()];

        for (int i = str.length()-1; i >= 0  ; i--) {
            reversedChar[str.length()-1 - i] += str.charAt(i);
        }
        return new String(reversedChar);
    }
     /*static String StringUtilsReverse(){
        return StringUtils.reverse(string);
    }*/

    static String reverseStringRecursion(String str){
        if(str.length() == 1)
            return str;

        return str.charAt(str.length()-1) + reverseStringRecursion(str.substring(0, str.length()-1));
    }


}

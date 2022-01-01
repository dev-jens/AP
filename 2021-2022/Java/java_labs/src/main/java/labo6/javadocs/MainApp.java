package labo6.javadocs;

public class MainApp {

	
	public static void main(String[] args) {
		
		
		KeyValues<Integer, String> keyValues = new KeyValues<>();
		keyValues.addValue(1, "String1");
		keyValues.addValue(2, "String2");
		keyValues.addValue(1, "String3");
		
		System.out.println(keyValues.getValue(1));
		System.out.println(keyValues);
		

		keyValues.addValueOverride(1, "String3");
		System.out.println(keyValues.getValue(1));
		System.out.println(keyValues);
	}
}

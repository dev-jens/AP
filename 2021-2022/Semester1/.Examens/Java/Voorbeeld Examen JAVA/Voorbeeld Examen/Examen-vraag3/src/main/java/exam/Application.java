package exam;

import exam.banking.BankApp;
import exam.banking.BankClient;

public class Application {
	public static void main(String[] args) {
		BankApp bankApp = new BankApp();
		BankClient jack = bankApp.addClient("Jack", 1000d, true);
		BankClient Peter = bankApp.addClient("Peter", 0d, false);
		System.out.println(jack);
		System.out.println(Peter);
		System.out.println(bankApp.withdrawAmount("Jack", 100d));
		System.out.println(bankApp.withdrawAmount("Peter", 100d));
		bankApp.disableClient("Jack");
		System.out.println(bankApp.getClients());
		System.out.println(bankApp.withdrawAmount("Jack", 100d));
	}

}

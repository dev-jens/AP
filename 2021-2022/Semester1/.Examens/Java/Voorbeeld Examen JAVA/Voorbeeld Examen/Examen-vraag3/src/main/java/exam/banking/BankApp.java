package exam.banking;

import java.util.ArrayList;
import java.util.Calendar;
import java.util.List;
import java.util.UUID;

public class BankApp {
	private List<BankClient> clients;

	public BankApp() {
		clients = new ArrayList<>();
	}

	public List<BankClient> getClients() {
		return clients;
	}

	public void setClients(List<BankClient> clients) {
		this.clients = clients;
	}

	public BankClient addClient(String name, double amount, boolean requiresCard) {
		if (name == null) {
			return null;
		}
		BankClient client = new BankClient();
		client.setName(name);
		client.setAmount(amount);
		client.setState(ClientState.ACTIVE);
		if (requiresCard) {
			client.setCardId(getNewCardId());
		}
		clients.add(client);
		return client;
	}

	public boolean withdrawAmount(String name, double amount) {
		for (BankClient client : clients) {
			if (client.getName().equals(name) && !ClientState.DISABLED.equals(client.getState())) {
				if (hasEnoughAmount(client, amount)) {
					client.setAmount(client.getAmount() - amount);
					return true;
				}
			}
		}
		return false;
	}

	public boolean hasEnoughAmount(BankClient client, double amount) {
		return client.getAmount() > amount;
	}

	public void disableClient(String name) {
		for (BankClient client : clients) {
			if (client.getName().equals(name) && !ClientState.DISABLED.equals(client.getState())) {
				client.setState(ClientState.DISABLED);
				return;
			}
		}
	}

	private String getNewCardId() {
		return Integer.toString(Calendar.getInstance().get(Calendar.YEAR)) + "-" + UUID.randomUUID().toString();
	}
}

package exam.banking;

public class BankClient {
	String name;
	Double amount;
	String cardId;
	ClientState State;
	public String getName() {
		return name;
	}
	public void setName(String name) {
		this.name = name;
	}
	public Double getAmount() {
		return amount;
	}
	public void setAmount(Double amount) {
		this.amount = amount;
	}
	public String getCardId() {
		return cardId;
	}
	public void setCardId(String cardId) {
		this.cardId = cardId;
	}
	public ClientState getState() {
		return State;
	}
	public void setState(ClientState state) {
		State = state;
	}
	@Override
	public String toString() {
		return "BankClient [name=" + name + ", amount=" + amount + ", cardId=" + cardId + ", State=" + State + "]";
	}
	
	
	
}

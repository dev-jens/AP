package edu.ap.spring.transaction;

import java.io.Serializable;
import java.security.*;

import edu.ap.spring.service.BlockChain;
import edu.ap.spring.service.StringUtil;

public class Transaction implements Serializable {
	
	private static final long serialVersionUID = 1L;
	public String transactionId; // contains a hash of transaction
	public PublicKey sender; // senders address/public key.
	public PublicKey recipient; // recipients address/public key.
	public float value; // contains the amount we wish to send to the recipient.
	public byte[] signature; // this is to prevent anybody else from spending funds in our wallet.
		
	public Transaction() {}

	public Transaction(PublicKey sender, PublicKey recipient , float value) {
		this.sender = sender;
		this.recipient = recipient;
		this.value = value;
		this.transactionId = StringUtil.applySha256( 
				sender.toString() +
				recipient.toString() +
				value
				);
	}

	public void setSender(PublicKey sender) {
		this.sender = sender;
	}

	public PublicKey getSender() {
		return this.sender;
	}
	
	public void setRecipient(PublicKey recipient) {
		this.recipient = recipient;
	}

	public PublicKey getRecipient() {
		return this.recipient;
	}
	
	public void setValue(float value) {
		this.value = value;
	}

	public float getValue() {
		return this.value;
	}
	
	public boolean processTransaction(BlockChain bChain) {
		if(verifySignature() == false) {
			System.out.println("# Transaction Signature failed to verify");
			return false;
		}
		return true;
	}
	
	public void generateSignature(PrivateKey privateKey) {
		String data = StringUtil.getStringFromKey(sender) + StringUtil.getStringFromKey(recipient) + Float.toString(value);
		signature = StringUtil.applyECDSASig(privateKey, data);		
	}
	
	public boolean verifySignature() {
		String data = StringUtil.getStringFromKey(sender) + StringUtil.getStringFromKey(recipient) + Float.toString(value);
		return StringUtil.verifyECDSASig(sender, data, signature);
	}
}

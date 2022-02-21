package edu.ap.spring.controller;

import javax.annotation.PostConstruct;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.*;

import edu.ap.spring.service.*;
import edu.ap.spring.transaction.Transaction;

import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestParam;

@Controller
public class MainController {

 	@Autowired
  	private BlockChain bChain;
  	@Autowired
  	private Wallet coinbase, walletA, walletB;
  	private Transaction genesisTransaction;

  	@PostConstruct
  	private void init() {
		bChain.setSecurity();
		coinbase.generateKeyPair();
		walletA.generateKeyPair();
		walletB.generateKeyPair();

		// create genesis transaction, which sends 100 coins to walletA:
		genesisTransaction = new Transaction(coinbase.getPublicKey(), walletA.getPublicKey(), 100f);
		genesisTransaction.generateSignature(coinbase.getPrivateKey());	 // manually sign the genesis transaction	
		genesisTransaction.transactionId = "0"; // manually set the transaction id
						
		// creating and Mining Genesis block
		Block genesis = new Block();
		genesis.setPreviousHash("0");
		genesis.addTransaction(genesisTransaction, bChain);
		bChain.addBlock(genesis);
  	}

  	@GetMapping(value="/")
   	public String index() {
	   return "redirect:/balance/walletA";
   	}

  	@GetMapping(value="/balance/{wallet}")
   	public String getBalance(@PathVariable("wallet") String wallet,
                             Model model) {
     	
	  model.addAttribute("wallet", wallet);

	  if(wallet.equalsIgnoreCase("walletA")) {
	  	model.addAttribute("balance", walletA.getBalance());
	  }
	  else if(wallet.equalsIgnoreCase("walletB")) {
		model.addAttribute("balance", walletB.getBalance());
	  }
	  else {
		model.addAttribute("balance", 0f);
	  }
      
    return "balance";
  	}

  	@GetMapping(value="/transaction")
  	public String getForm() {
	  return "transaction";
  	}

  	@PostMapping(value="/transaction")
  	public String transaction(@RequestParam("wallet1") String wallet1, 
                              @RequestParam("wallet2") String wallet2,
                              @RequestParam("amount") float amount) {
	
		Block block = new Block();
	  	block.setPreviousHash(bChain.getLastHash());

		try {
			if(wallet1.equalsIgnoreCase("walletA") && wallet2.equalsIgnoreCase("walletB")) {
				block.addTransaction(walletA.sendFunds(walletB.getPublicKey(), amount), bChain);
			}
			else if(wallet1.equalsIgnoreCase("walletB") && wallet2.equalsIgnoreCase("walletA")) {
				block.addTransaction(walletB.sendFunds(walletA.getPublicKey(), amount), bChain);
			}
			else {
				block.addTransaction(walletA.sendFunds(walletA.getPublicKey(), amount), bChain);
			}
		}
		catch(Exception e) {}
		
	  bChain.addBlock(block);
		
      return "redirect:/balance/" + wallet1;
    }

	@GetMapping(value="/alltransactions")
	public @ResponseBody String alltransactions() {
		return this.bChain.toJSON();
	}

	@GetMapping(value="/valid")
	public @ResponseBody String testValidity() {
		return "Valid : " + this.bChain.isValid();
	}
}

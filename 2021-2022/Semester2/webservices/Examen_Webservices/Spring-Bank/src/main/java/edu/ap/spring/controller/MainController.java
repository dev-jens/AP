package edu.ap.spring.controller;

import javax.annotation.PostConstruct;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.*;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestParam;

import edu.ap.spring.jpa.Wallet;
import edu.ap.spring.jpa.WalletRepository;

@Controller
public class MainController {

	@Autowired
	private WalletRepository walletRepository;

	@PostConstruct
	private void init() {

		walletRepository.save(new Wallet("walletA", 50));
		walletRepository.save(new Wallet("walletB", 50));
	}

	@GetMapping(value = "/")
	public String index() {
		return "redirect:/balance/walletA";
	}

	@GetMapping(value = "/balance/{wallet}")
	public String getBalance(@PathVariable("wallet") String walletName,
			Model model) {

		Wallet walletFound = walletRepository.findByWalletname(walletName);
			
		System.out.println(walletRepository.findByWalletname("walletA"));
		model.addAttribute("wallet", walletName);

		if (walletName.equalsIgnoreCase("walletA")) {
			model.addAttribute("balance", walletFound.getBalance());
		} else if (walletName.equalsIgnoreCase("walletB")) {
			model.addAttribute("balance", walletFound.getBalance());
		} else {
			model.addAttribute("balance", 0f);
		}

		return "balance";
	}

	@GetMapping(value = "/transaction")
	public String transactionForm() {
		return "transaction";
	}

	@PostMapping(value = "/transaction")
	public String transaction(@RequestParam("wallet1") String wallet1Name,
			@RequestParam("wallet2") String wallet2Name,
			@RequestParam("amount") float amount) {

		Wallet wallet1 = walletRepository.findByWalletname(wallet1Name);
		Wallet wallet2 = walletRepository.findByWalletname(wallet2Name);
		
		try {
			if (wallet1Name.equalsIgnoreCase("walletA") && wallet2Name.equalsIgnoreCase("walletB")) {
				if(wallet1.getBalance() < amount){
					return "error";
				}
				wallet1.setBalance(wallet1.getBalance() - amount);
				wallet2.setBalance(wallet2.getBalance() + amount);

			} else if (wallet1Name.equalsIgnoreCase("walletB") && wallet2Name.equalsIgnoreCase("walletA")) {
				if(wallet1.getBalance() < amount){
					return "error";
				}
				wallet1.setBalance(wallet1.getBalance() - amount);
				wallet2.setBalance(wallet2.getBalance() + amount);
			} 
		} catch (Exception e) {
		}

		walletRepository.save(wallet1);
		walletRepository.save(wallet2);

		return "redirect:/balance/" + wallet1Name;
	}
}

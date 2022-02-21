package edu.ap.spring.test;

import static org.junit.jupiter.api.Assertions.assertEquals;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

import org.mockito.Mockito;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.context.SpringBootTest;

import edu.ap.spring.service.Block;
import edu.ap.spring.service.BlockChain;
import edu.ap.spring.service.Wallet;
import edu.ap.spring.transaction.Transaction;

@SpringBootTest
public class SpringTest{
    @Autowired
    private BlockChain bChain;
    @Autowired
    private Wallet coinbase, walletA, walletB;
    private Wallet walletC = Mockito.mock(Wallet.class);
    private Transaction genesisTransaction;

    @BeforeEach
    public void init(){
        bChain.setSecurity();
        coinbase.generateKeyPair();
        walletA.generateKeyPair();
        walletB.generateKeyPair();

        genesisTransaction = new Transaction(coinbase.getPublicKey(), walletA.getPublicKey(), 100f);
        genesisTransaction.generateSignature(coinbase.getPrivateKey());
        genesisTransaction.transactionId = "0";

        Block genesisBlock = new Block();
        genesisBlock.setPreviousHash("0");
        genesisBlock.addTransaction(genesisTransaction, bChain);
        bChain.addBlock(genesisBlock);
    }

    @Test
    public void transactionTest(){
        Block block = new Block();
        block.setPreviousHash(bChain.getLastHash());

        try {
            block.addTransaction(walletA.sendFunds(walletB.getPublicKey(), 40f), bChain);
            block.addTransaction(walletA.sendFunds(walletB.getPublicKey(), 10f), bChain);
        } catch(Exception e){}

        bChain.addBlock(block);

        assertEquals(50f, walletA.getBalance());
        assertEquals(50f, walletB.getBalance());

    }

	@Test
	public void test2(){
        Block block1 = new Block();
        block1.setPreviousHash(bChain.getLastHash());
        bChain.addBlock(block1);

        try {
            block1.addTransaction(walletA.sendFunds(walletB.getPublicKey(), 80f), bChain);
        
        } catch(Exception e){}

        Block block2 = new Block();
        block2.setPreviousHash(bChain.getLastHash());

        try {
            block2.addTransaction(walletB.sendFunds(walletA.getPublicKey(), 40f), bChain);
        
        } catch(Exception e){}

        bChain.addBlock(block2);
        
        assertEquals(60f, walletA.getBalance());
        assertEquals(40f, walletB.getBalance());

	}
    @Test
	public void test3(){
        Mockito.when(walletC.getBalance()).thenReturn(50f);
        assertEquals(50f, walletC.getBalance());
    
	}
}
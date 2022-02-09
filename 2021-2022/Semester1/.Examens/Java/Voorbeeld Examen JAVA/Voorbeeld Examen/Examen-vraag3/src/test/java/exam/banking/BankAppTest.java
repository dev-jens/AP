package exam.banking;

import org.junit.jupiter.api.Test;

import java.util.ArrayList;
import java.util.List;

import static org.junit.jupiter.api.Assertions.*;

public class BankAppTest {

    @Test
    void createBankApp() {
        BankApp bankApp = new BankApp();
        assertEquals(0,bankApp.getClients().size());

    }
    @Test
    void setClientBankApp() {
        BankApp bankApp = new BankApp();
        List<BankClient> clientList = new ArrayList<>();
        clientList.add(new BankClient());
        bankApp.setClients(clientList);
        assertEquals(1,bankApp.getClients().size());

    }
    @Test
    void setClientNameNullResultsNull() {
        BankApp bankApp = new BankApp();
        BankClient client = bankApp.addClient(null,50,false);
        assertNull(client);


    }
    @Test
    void addClientBankAppHas1Client() {
        BankApp bankApp = new BankApp();
        bankApp.addClient("jens",50,false);
        assertEquals(1,bankApp.getClients().size());

    }
    @Test
    void addClientIsRightClientNoCard() {
        BankApp bankApp = new BankApp();
        BankClient client = bankApp.addClient("jens",50,false);
        assertEquals("jens", client.getName());
        assertEquals(50, client.getAmount());
        assertNull(client.getCardId());
        assertEquals(client.getState(), ClientState.ACTIVE);

    }
    @Test
    void addClientIsRightClientWithCard() {
        BankApp bankApp = new BankApp();
        BankClient client = bankApp.addClient("jens",50,true);
        assertEquals("jens", client.getName());
        assertEquals(50, client.getAmount());
        assertNotNull(client.getCardId());
        assertEquals(client.getState(), ClientState.ACTIVE);

    }
    @Test
    void checkIfClientHasWidrawAmount() {
        BankApp bankApp = new BankApp();
        BankClient client = bankApp.addClient("jokke",5000,true);
        assertTrue(bankApp.withdrawAmount("jokke",100));

    }
    @Test
    void checkIfClientHasNotEnoughMoneyToWidraw() {
        BankApp bankApp = new BankApp();
        BankClient client = bankApp.addClient("jokke",50,false);
        assertFalse(bankApp.withdrawAmount("jokke",100));

    }
    @Test
    void disableClientStateWithCorrectName() {
        BankApp bankApp = new BankApp();
        BankClient client = bankApp.addClient("jokke",50,false);
        bankApp.disableClient("jokke");
        assertEquals(ClientState.DISABLED,client.getState());

    }
    @Test
    void disableClientStateWithFalseName() {
        BankApp bankApp = new BankApp();
        BankClient client = bankApp.addClient("brokke",50,false);
        bankApp.disableClient("jokke");
        assertEquals(ClientState.ACTIVE,client.getState());

    }
    @Test
    void checkToString() {
        BankClient client = new BankClient();
        client.setName("jens");
        client.setAmount(500.0);
        client.setCardId("12345");
        client.setState(ClientState.ACTIVE);
        String toStringTekst = "BankClient [name=" + client.getName() + ", amount=" + client.getAmount() + ", cardId=" + client.getCardId() + ", State=" + client.getState() + "]";
        assertEquals(toStringTekst,client.toString());

    }

}

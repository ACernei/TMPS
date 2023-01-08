namespace Lab4.State;

public class CreditCardMachine : ICreditCardMachineState
{
    private ICreditCardMachineState CreditCardMachineState { get; set; }

    public CreditCardMachine()
    {
        CreditCardMachineState = new CardNotInsertedState();
    }

    public void InsertCard()
    {
        CreditCardMachineState.InsertCard();

        if (CreditCardMachineState is CardNotInsertedState)
        {
            CreditCardMachineState = new CardInsertedState();
        }
    }

    public void EjectCard()
    {
        CreditCardMachineState.EjectCard();

        if (CreditCardMachineState is CardInsertedState)
        {
            CreditCardMachineState = new CardNotInsertedState();
        }
    }

    public bool EnterPin()
    {
        return CreditCardMachineState.EnterPin();
    }
}

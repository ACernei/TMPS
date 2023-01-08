namespace Lab4.State;

public interface ICreditCardMachineState
{
    void InsertCard();
    void EjectCard();
    bool EnterPin();
}

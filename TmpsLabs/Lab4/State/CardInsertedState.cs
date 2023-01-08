namespace Lab4.State;

public class CardInsertedState : ICreditCardMachineState
{
    public void InsertCard()
    {
        Console.WriteLine("Card already inserted");
    }
    public void EjectCard()
    {
        Console.WriteLine("Card ejected");
    }
    public bool EnterPin()
    {
        Console.WriteLine("Pin number has been entered correctly");
        Console.WriteLine("Successful payment");
        return true;
    }
}

namespace Lab4.State;

public class CardNotInsertedState : ICreditCardMachineState
{
    public void InsertCard()
    {
        Console.WriteLine("Card Inserted");
    }
    public void EjectCard()
    {
        Console.WriteLine("You cannot eject the card, there is no card inserted");
    }
    public bool EnterPin()
    {
        Console.WriteLine("You cannot enter the pin, there is no card inserted");
        return false;
    }
}

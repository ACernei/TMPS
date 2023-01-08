namespace Lab4.Observer;

public class Observer : IObserver
{
    public string UserName { get; set; }
    public Observer(string userName, IOrder order)
    {
        UserName = userName;
        order.AddObserver(this);
    }

    public void Update(string availability)
    {
        Console.WriteLine($"Hello {UserName}. You can let him leave the restaurant");
    }
}

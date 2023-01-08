namespace Lab4.Observer;

public class Order : IOrder
{
    private List<IObserver> observers = new();
    private string OrderStatus { get; set; }
    public Order(string orderStatus)
    {
        OrderStatus = orderStatus;
    }

    public string GetOrderStatus()
    {
        return OrderStatus;
    }
    public void SetOrderStatus(string orderStatus)
    {
        this.OrderStatus = orderStatus;
        NotifyObservers();
    }
    public void AddObserver(IObserver observer)
    {
        observers.Add(observer);
        Console.WriteLine($"Observer Added: {((Observer)observer).UserName}");
    }
    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
        Console.WriteLine($"Observer Removed: {((Observer)observer).UserName}");
    }
    public void NotifyObservers()
    {
        Console.WriteLine("Client has paid for the order, you can let him leave the restaurant");
        Console.WriteLine();
        foreach (var observer in observers)
        {
            observer.Update(OrderStatus);
        }
    }
}

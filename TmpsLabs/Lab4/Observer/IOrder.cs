namespace Lab4.Observer;

public interface IOrder
{
    void AddObserver(IObserver observer);
    void RemoveObserver(IObserver observer);
    void NotifyObservers();
}

namespace Lab4.Strategy;

public class   EatSlowStrategy : IEatStrategy
{
    public void Eat(Person person)
    {
        Console.WriteLine("You have enough time, eat slowly.");
    }
}

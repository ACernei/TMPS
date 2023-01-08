namespace Lab4.Strategy;

public class EatFastStrategy : IEatStrategy
{
    public void Eat(Person person)
    {
        Console.WriteLine($"You have only {person.FreeTime} minutes, hurry up!");
    }
}

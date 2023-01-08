namespace Lab4.Command;

public class EatWithForkCommand : ICommand
{
    private readonly Food food;
    public EatWithForkCommand (Food food)
    {
        this.food = food;
    }
    public void Execute()
    {
        food.EatWithFork();
    }
}

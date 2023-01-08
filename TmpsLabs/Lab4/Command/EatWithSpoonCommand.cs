namespace Lab4.Command;

public class EatWithSpoonCommand : ICommand
{
    private readonly Food food;
    public EatWithSpoonCommand (Food food)
    {
        this.food = food;
    }
    public void Execute()
    {
        food.EatWithSpoon();
    }
}

namespace Lab4.Command;

public class EatWithHandsCommand : ICommand
{
    private readonly Food food;
    public EatWithHandsCommand (Food food)
    {
        this.food = food;
    }
    public void Execute()
    {
        food.EatWithHands();
    }
}

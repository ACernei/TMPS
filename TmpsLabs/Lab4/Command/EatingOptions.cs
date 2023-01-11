namespace Lab4.Command;

public class EatingOptions
{
    private readonly ICommand eatWithForkCommand;
    private readonly ICommand eatWithHandsCommand;
    private readonly ICommand eatWithSpoonCommand;
    public EatingOptions(ICommand eatWithFork, ICommand eatWithHands, ICommand eatWithSpoon)
    {
        this.eatWithForkCommand = eatWithFork;
        this.eatWithHandsCommand = eatWithHands;
        this.eatWithSpoonCommand = eatWithSpoon;
    }
    public void ChooseFork()
    {
        eatWithForkCommand.Execute();
    }
    public void ChooseHands()
    {
        eatWithHandsCommand.Execute();
    }
    public void ChooseSpoon()
    {
        eatWithSpoonCommand.Execute();
    }
}

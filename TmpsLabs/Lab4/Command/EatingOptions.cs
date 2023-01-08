namespace Lab4.Command;

public class EatingOptions
{
    private readonly ICommand openCommand;
    private readonly ICommand saveCommand;
    private readonly ICommand closeCommand;
    public EatingOptions(ICommand eatWithFork, ICommand eatWithHands, ICommand eatWithSpoon)
    {
        this.openCommand = eatWithFork;
        this.saveCommand = eatWithHands;
        this.closeCommand = eatWithSpoon;
    }
    public void ChooseFork()
    {
        openCommand.Execute();
    }
    public void ChooseHands()
    {
        saveCommand.Execute();
    }
    public void ChooseSpoon()
    {
        closeCommand.Execute();
    }
}

namespace Lab4.Template;

public class MakePotatoBurger : MakeBurger
{
    protected override void SelectBun()
    {
        Console.WriteLine("Adding bun");
    }

    protected override void AddPatty()
    {
        Console.WriteLine("Adding potato patty");
    }

    protected override void AddSauces()
    {
        Console.WriteLine("Adding sauces");
    }
}

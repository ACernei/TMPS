namespace Lab4.Template;

public class MakeChickenBurger : MakeBurger
{
    protected override void SelectBun()
    {
        Console.WriteLine("Adding bun");
    }

    protected override void AddPatty()
    {
        Console.WriteLine("Adding chicken patty");
    }

    protected override void AddSauces()
    {
        Console.WriteLine("Adding sauces");
    }
}

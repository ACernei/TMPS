namespace Lab4.Template;

public abstract class MakeBurger
{
    public void Prepare()
    {
        SelectBun();
        AddPatty();
        AddSauces();
        Pack();
    }

    protected abstract void SelectBun();
    protected abstract void AddPatty();
    protected abstract void AddSauces();

    private void Pack()
    {
        Console.WriteLine();
        Console.WriteLine("Your burger is ready.");
        Console.WriteLine("Bon appetit");

    }
}

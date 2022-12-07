namespace Lab3.Facade;

public abstract class Edible
{
    protected bool IsEaten;

    public void Eat()
    {
        if (IsEaten)
        {
            throw new Exception("Already eaten!");
        }

        IsEaten = true;
    }
}

namespace Lab3.Proxy;

public class SecureNestProxy : INest
{
    private readonly INest nest;

    public SecureNestProxy(INest nest)
    {
        this.nest = nest;
    }

    public void Access(string name)
    {
        if (name is "Snake" or "Eagle")
        {
            Console.WriteLine($"{name} is not allowed to access the nest.");
        }
        else
        {
            this.nest.Access(name);
        }
    }
}

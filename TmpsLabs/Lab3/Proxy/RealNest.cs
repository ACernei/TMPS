namespace Lab3.Proxy;

public class RealNest : INest
{
    public void Access(string name)
    {
        Console.WriteLine($"{name} has access to the nest");
    }
}

namespace Lab3.Composite;

public class SingleItem : ItemBase
{
    public SingleItem(string name, int weight)
        :base(name, weight)
    {
    }
    public override int CalculateTotalWeight()
    {
        Console.WriteLine($"{Name} with the weight {Weight}");
        return Weight;
    }
}

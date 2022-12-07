namespace Lab3.Composite;

public abstract class ItemBase
{
    protected readonly string Name;
    protected readonly int Weight;

    protected ItemBase(string name, int weight)
    {
        this.Name = name;
        this.Weight = weight;
    }
    public abstract int CalculateTotalWeight();
}

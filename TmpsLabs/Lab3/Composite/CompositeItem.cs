namespace Lab3.Composite;

public class CompositeItem : ItemBase, IItemOperations
{
    private List<ItemBase> items;

    public CompositeItem(string name, int weight)
        : base(name, weight)
    {
        items = new List<ItemBase>();
    }

    public void Add(ItemBase item)
    {
        items.Add(item);
    }

    public void Remove(ItemBase item)
    {
        items.Remove(item);
    }

    public override int CalculateTotalWeight()
    {
        var total = 0;
        Console.WriteLine($"{Name} contains the following products:");
        foreach (var item in items)
        {
            total += item.CalculateTotalWeight();
        }

        return total;
    }
}

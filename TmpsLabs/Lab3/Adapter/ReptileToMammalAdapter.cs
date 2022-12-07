namespace Lab3.Adapter;

public class ReptileToMammalAdapter : IMammal
{
    private readonly Reptile reptile;

    public ReptileToMammalAdapter(Reptile reptile)
    {
        this.reptile = reptile;
    }

    public IChild GiveBirth()
    {
        ReptileEgg egg = reptile.LayEgg();

        IChild child = egg.Hatch();

        return child;
    }
}

namespace Lab3.Adapter;

public class ReptileEgg
{
    public IChild Hatch()
    {
        return new ReptileChild();
    }
}

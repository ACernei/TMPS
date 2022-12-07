namespace Lab3.Adapter;

public static class ChildCreator
{
    public static IChild CreateChild(IMammal mammal)
    {
        return mammal.GiveBirth();
    }
}

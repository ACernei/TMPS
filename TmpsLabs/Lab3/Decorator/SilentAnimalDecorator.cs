namespace Lab3.Decorator;

public class SilentAnimalDecorator : IAnimal
{
    private readonly IAnimal animal;

    public SilentAnimalDecorator(IAnimal animal)
    {
        this.animal = animal;
    }

    public string Roar()
    {
        return "";
    }
}

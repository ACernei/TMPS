namespace Lab3.Decorator;

public class LoudAnimalDecorator : IAnimal
{
    private readonly IAnimal animal;

    public LoudAnimalDecorator(IAnimal animal)
    {
        this.animal = animal;
    }

    public string Roar()
    {
        return $"{this.animal.Roar()} loudly";
    }
}

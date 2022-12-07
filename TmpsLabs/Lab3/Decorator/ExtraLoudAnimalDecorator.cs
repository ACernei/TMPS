namespace Lab3.Decorator;

public class ExtraLoudAnimalDecorator : IAnimal
{
    protected readonly IAnimal Animal;

    public ExtraLoudAnimalDecorator(IAnimal animal)
    {
        this.Animal = animal;
    }

    public string Roar()
    {
        return $"{this.Animal.Roar()}!!!";
    }
}

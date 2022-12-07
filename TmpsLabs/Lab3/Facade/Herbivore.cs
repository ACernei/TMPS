namespace Lab3.Facade;

public class Herbivore : Edible
{
    public Herbivore(Plant plant)
    {
        Console.WriteLine("The herbivore eats a plant.");
        plant.Eat();
        IsEaten = false;
    }
}

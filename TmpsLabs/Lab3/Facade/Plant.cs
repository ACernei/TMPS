namespace Lab3.Facade;

public class Plant : Edible
{
    public Plant(Soil soil)
    {
        Console.WriteLine("A new plant grows");
        soil.UseNutrient();
        this.IsEaten = false;
    }
}

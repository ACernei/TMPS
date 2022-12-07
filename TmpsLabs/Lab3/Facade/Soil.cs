namespace Lab3.Facade;

public class Soil
{
    private int nutrientCount;

    public Soil(int nutrientCount)
    {
        Console.WriteLine($"The soil has {nutrientCount} nutrient(s)");
        this.nutrientCount = nutrientCount;
    }

    public void AddNutrient(Edible edible)
    {
        Console.WriteLine("The soil gains nutrients");
        edible.Eat();
        nutrientCount++;
        Console.WriteLine($"Nutrient count: {nutrientCount}");
    }

    public void UseNutrient()
    {
        if (nutrientCount <= 0)
        {
            throw new Exception("No nutrients left!");
        }

        nutrientCount--;
        Console.WriteLine($"Nutrient count: {nutrientCount}");
    }
}

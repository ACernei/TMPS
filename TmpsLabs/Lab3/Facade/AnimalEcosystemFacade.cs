namespace Lab3.Facade;

public class AnimalEcosystemFacade
{
    private readonly Soil soil;

    public AnimalEcosystemFacade(Soil soil)
    {
        this.soil = soil;
    }

    public void RunAGeneration()
    {
        var plant = new Plant(this.soil);
        var herbivore = new Herbivore(plant);
        var carnivore = new Carnivore(herbivore);
        carnivore.Die(this.soil);
    }
}

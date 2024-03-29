﻿namespace Lab3.Facade;

public class Carnivore : Edible
{
    public Carnivore(Herbivore herbivore)
    {
        Console.WriteLine("The carnivore eats the herbivore");
        herbivore.Eat();
        IsEaten = false;
    }

    public void Die(Soil soil)
    {
        Console.WriteLine("The carnivore dies");
        soil.AddNutrient(this);
    }
}

# Design Patterns

In this project I implemented 5 structural design patterns

- Adapter - Allows objects with incompatible interfaces to collaborate.
- Composite - Lets you compose objects into tree structures and then work with these structures as if they were individual objects.
- Decorator - ets you attach new behaviors to objects by placing these objects inside special wrapper objects that contain the behaviors.
- Facade - Provides a simplified interface to a library, a framework, or any other complex set of classes.
- Proxy - Lets you provide a substitute or placeholder for another object. 

## Adapter
The adapter pattern is useful when you want to use a class that does not fit the design of your existing solution. This is often the case when using legacy or external code. The adapter pattern allows you to define a wrapper which executes the desired behaviour, but exposes it through a method which your solution expects.

So, today we've been transported to a post-meteor world...

And in this world, in the age of mammals, we have a ChildCreator that expects things to work in a certain way:

The GiveBirth method produces an IChild, which has a single method, Cry
```
public interface IChild
{
    void Cry();
}
```
However, though the world has moved on, we have a few legacy reptile hanging around, that are just trying to get along in an unfamiliar place... Unfortunately reptile works somewhat differently to the majority of mammals, possessing a LayEgg method:
```
public class ReptileEgg
{
    public IChild Hatch()
    {
        return new ReptileChild();
    }
}
```
We need a way that our ChildCreator can work with the Reptile to produce a child.

If we define a ReptileToMammalAdapter, which implements the IMammal class, and wraps an internal Reptile:
```
public ReptileToMammalAdapter(Reptile reptile)
{
    this.reptile = reptile;
}

public IChild GiveBirth()
{
    ReptileEgg egg = reptile.LayEgg();

    IChild child = egg.Hatch();

    return child;
}
```

Then the GiveBirth method can call the LayEgg method of the internal Reptile, and then Hatch that egg to produce an IChild
```
var reptile = new Reptile();
var child = ChildCreator.CreateChild(new ReptileToMammalAdapter(reptile));

child.Cry();
```
## Composite

Let’s imagine that we need to calculate the total weight of a luggage which a monkey should carry. The luggage could be a single element or it can be a complex item that consists of a luggage with two items and another box with maybe one item and the box with a single item inside. As we can see, we have a tree structure representing our complex item so, implementing the Composite design pattern will be the right solution for us.

Component part (ItemBase):
```
public abstract class ItemBase
{
    protected readonly string Name;
    protected readonly int Weight;

    protected ItemBase(string name, int weight)
    {
        this.Name = name;
        this.Weight = weight;
    }
    public abstract int CalculateTotalWeight();
}
```
Component part (CompositeItem):
```
public class CompositeItem : ItemBase, IItemOperations
{
    private List<ItemBase> items;

    public CompositeItem(string name, int weight)
        : base(name, weight)
    {
        items = new List<ItemBase>();
    }

    public void Add(ItemBase item)
    {
        items.Add(item);
    }

    public void Remove(ItemBase item)
    {
        items.Remove(item);
    }

    public override int CalculateTotalWeight()
    {
        var total = 0;
        Console.WriteLine($"{Name} contains the following products:");
        foreach (var item in items)
        {
            total += item.CalculateTotalWeight();
        }

        return total;
    }
}
```
Leaf class:
```
public class SingleItem : ItemBase
{
    public SingleItem(string name, int weight)
        :base(name, weight)
    {
    }
    public override int CalculateTotalWeight()
    {
        Console.WriteLine($"{Name} with the weight {Weight}");
        return Weight;
    }
}
```
Implementation:
```
Console.WriteLine("A monkey wet to store and wants to know how much does its luggage weight");

var luggage = new CompositeItem("Luggage", 0);
var cola = new SingleItem("Cola", 2);
var water = new SingleItem("Water", 2);
luggage.Add(cola);
luggage.Add(water);
var boxFromLuggage = new CompositeItem("Box from the luggage", 0);
var cake = new SingleItem("Cake", 2);
boxFromLuggage.Add(cake);
luggage.Add(boxFromLuggage);

Console.WriteLine($"Total weight of this composite luggage is: {luggage.CalculateTotalWeight()}");
```
## Decorator
To use the decorator pattern, you wrap an object in another object in order to extend behaviour. The objects all implement the same interface, so the decorators can stack on top of one another, extendng the behaviour further.

we implement that IAnimal interface with a class:
public interface IAnimal
```
public class Animal : IAnimal
{
    public string Roar()
    {
        return "ROAR";
    }
}
```
Wrap the initial animal object in a Decorator:
```
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
```
We have a second Decorator which extends the behaviour further:
```
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
```
We build up our wrapped object as follows:
```
var animal = new Animal();

Console.WriteLine(animal.Roar());
var silentAnimal = new SilentAnimalDecorator(animal);
var loudAnimal = new LoudAnimalDecorator(animal);
var extraLoudAnimal = new ExtraLoudAnimalDecorator(loudAnimal);
```
## Facade
The facade pattern is a useful for providing a simple interface into a complex system. It doesn't provide access to all parts of the system, it provides a limited set of functionality and hides any underlying complexity.

We have a complex ecosystem, everything starts with the nutrients in the soil:
```
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
```
We then have Plants, which use the nutrients in order to grow:
```
public class Plant : Edible
{
    public Plant(Soil soil)
    {
        Console.WriteLine("A new plant grows");
        soil.UseNutrient();
        this.IsEaten = false;
    }
}
```
Plants are then eaten by Herbivores
```
public class Herbivore : Edible
{
    public Herbivore(Plant plant)
    {
        Console.WriteLine("The herbivore eats a plant.");
        plant.Eat();
        IsEaten = false;
    }
}
```
And in turn these Herbivores are eaten by Carnivores:
```
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
```
Eventually the Carnivores Die, and return the nutrients to the soil.

```
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
```
Implementation:
```
var animalEcosystemFacade = new AnimalEcosystemFacade(new Soil(1));
animalEcosystemFacade.RunAGeneration();
```
## Proxy
The proxy pattern is used to provide access to an object. It is often used to enable this access over some distance - this could be providing remote access, or adding an extra level of protection around the object. The crucial thing is that the proxy pattern offers a way to indirectly provide (and control) access.

The proxy pattern can be used to restrict access to an object, to provide a simpler or lightweight interface, or to allow the client to communicate with a remote object via a local representation.

INest is implemented by a RealNest:
```
public class RealNest : INest
{
    public void Access(string name)
    {
        Console.WriteLine($"{name} has access to the nest");
    }
}
```
Now, we don't want just anyone to be able to access our Nest. We need to be able to restrict access to only those that aren't going to cause harm. To do this, we can implement a SecureNestProxy:
```
public class SecureNestProxy : INest
{
    private readonly INest nest;

    public SecureNestProxy(INest nest)
    {
        this.nest = nest;
    }

    public void Access(string name)
    {
        if (name is "Snake" or "Eagle")
        {
            Console.WriteLine($"{name} is not allowed to access the nest.");
        }
        else
        {
            this.nest.Access(name);
        }
    }
}
```
This Proxy will reject access for snake and eagle

Implementation:
```
var secureNestProxy = new SecureNestProxy(new RealNest());

secureNestProxy.Access("Turtle");
secureNestProxy.Access("Snake");
```
## Conclusion
In this project I implemented 5 Structural design patterns

using Lab3.Adapter;
using Lab3.Composite;
using Lab3.Decorator;
using Lab3.Facade;
using Lab3.Proxy;

// --- Facade ---
Console.WriteLine("--- Facade ---");

var meteor = false;
var animalEcosystemFacade = new AnimalEcosystemFacade(new Soil(1));

while (!meteor)
{
    animalEcosystemFacade.RunAGeneration();

    // --- Decorator ---
    Console.WriteLine("--- Decorator ---");

    Console.WriteLine("Some animals are still alive");
    Console.WriteLine("You can hear how they sing");

    var animal = new Animal();

    Console.WriteLine(animal.Roar());
    var silentAnimal = new SilentAnimalDecorator(animal);
    var loudAnimal = new LoudAnimalDecorator(animal);
    var extraLoudAnimal = new ExtraLoudAnimalDecorator(loudAnimal);

    Console.WriteLine(silentAnimal.Roar());
    Console.WriteLine(loudAnimal.Roar());
    Console.WriteLine(extraLoudAnimal.Roar());

    Console.WriteLine();

    // --- Proxy ---
    Console.WriteLine("--- Proxy ---");
    Console.WriteLine("Look there are some turtle nests");
    Console.WriteLine("I wonder who is allowed to access the nest");

    var secureNestProxy = new SecureNestProxy(new RealNest());

    secureNestProxy.Access("Turtle");
    secureNestProxy.Access("Snake");

    Console.WriteLine();

    // --- Adapter ---
    Console.WriteLine("--- Adapter ---");
    Console.WriteLine("Are there only mammals in this ecosystem?");
    Console.WriteLine("Oh look there is a baby reptile crying");

    var reptile = new Reptile();

    var child = ChildCreator.CreateChild(new ReptileToMammalAdapter(reptile));

    child.Cry();

    Console.WriteLine();

    // --- Composite ---
    Console.WriteLine("--- Composite ---");

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


    Console.WriteLine("Has a meteor hit? (Y/N)");
    var response = Console.ReadLine();
    if (response == "Y")
    {
        meteor = true;
    }
}

Console.WriteLine("A meteor has hit and destroyed the ecosystem!");

// --- Decorator ---
// Console.WriteLine("--- Decorator ---");
//
// var animal = new Animal();
//
// Console.WriteLine(animal.Roar());
// var silentAnimal = new SilentAnimalDecorator(animal);
// var loudAnimal = new LoudAnimalDecorator(animal);
// var extraLoudAnimal = new ExtraLoudAnimalDecorator(loudAnimal);
//
// Console.WriteLine(silentAnimal.Roar());
//
// Console.WriteLine(loudAnimal.Roar());
//
// Console.WriteLine(extraLoudAnimal.Roar());
//
// Console.WriteLine();

// --- Proxy ---
// Console.WriteLine("--- Proxy ---");
//
// var secureNestProxy = new SecureNestProxy(new RealNest());
//
// secureNestProxy.Access("Turtle");
// secureNestProxy.Access("Snake");
//
// Console.WriteLine();

// --- Adapter ---
// Console.WriteLine("--- Adapter ---");
//
// var reptile = new Reptile();
//
// var child = ChildCreator.CreateChild(new ReptileToMammalAdapter(reptile));
//
// child.Cry();
//
// Console.WriteLine();


// --- Composite ---
// Console.WriteLine("--- Composite ---");
//
// var luggage = new CompositeItem("Luggage", 0);
// var cola = new SingleItem("Cola", 2);
// var water = new SingleItem("Water", 2);
// luggage.Add(cola);
// luggage.Add(water);
// var boxFromLuggage = new CompositeItem("Box from the luggage", 0);
// var cake = new SingleItem("Cake", 2);
// boxFromLuggage.Add(cake);
// luggage.Add(boxFromLuggage);
// Console.WriteLine($"Total weight of this composite luggage is: {luggage.CalculateTotalWeight()}");

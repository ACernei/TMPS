using Lab4;
using Lab4.Command;
using Lab4.Observer;
using Lab4.State;
using Lab4.Strategy;
using Lab4.Template;

var person = new Person
{
    Name = "Andrew", Age = 21, IsVegetarian = false, FreeTime = 100
};
Console.WriteLine($"Hi, my name is {person.Name}");
Console.WriteLine("I'm very hungry");

Console.WriteLine("...");
Console.WriteLine("(At the restaurant:)");

//Template
if (person.IsVegetarian)
{
    Console.WriteLine("Hi. I want to eat a potato burger");
    Console.WriteLine("...");
    Console.WriteLine("(Chef in the kitchen:)");

    var burger = new MakePotatoBurger();
    burger.Prepare();
}
else
{
    Console.WriteLine("Hi. I want to eat a chicken burger");
    Console.WriteLine("...");
    Console.WriteLine("(Chef in the kitchen:)");

    var burger = new MakeChickenBurger();
    burger.Prepare();
}
//----------

Console.WriteLine();

Console.WriteLine("How should I eat this burger?");
Console.WriteLine();
Console.WriteLine("With fork, bare hands or spoon");

//Command
var food = new Food();
ICommand eatWithForkCommand = new EatWithForkCommand(food);
ICommand eatWithHandsCommand = new EatWithHandsCommand(food);
ICommand eatWithSpoonCommand = new EatWithSpoonCommand(food);
var eatingOptions = new EatingOptions(eatWithForkCommand, eatWithHandsCommand, eatWithSpoonCommand);

Console.WriteLine("Lets choose hands");
Console.WriteLine();

eatingOptions.ChooseHands();
//----------


Console.WriteLine();
//Strategy
var eatStrategySelector = new EatStrategySelector();

eatStrategySelector
    .SelectEatStrategy(person.FreeTime)
    .Eat(person);

person.FreeTime = 15;
eatStrategySelector
    .SelectEatStrategy(person.FreeTime)
    .Eat(person);
//----------

Console.WriteLine();
Console.WriteLine("Let's pay for the meal and go to work.");

Console.WriteLine();

//Observer
var order = new Order("Order not paid");
Console.WriteLine($"Order current status: {order.GetOrderStatus()}");

Console.WriteLine("3 guards arrived to stop you from leaving the restaurant without paying");

Console.WriteLine();
var security1 = new Observer("Alice", order);
var security2 = new Observer("Bob", order);
var observers = new Observer("Carol", order);
//----------

Console.WriteLine();

//Observer
var creditCardMachine = new CreditCardMachine();

Console.WriteLine("(credit Card Machine:)");
creditCardMachine.EnterPin();
creditCardMachine.EjectCard();
creditCardMachine.InsertCard();

Console.WriteLine();
creditCardMachine.EnterPin();

Console.WriteLine();
order.SetOrderStatus("Order paid");
//----------

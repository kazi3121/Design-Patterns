// 1. Order a basic plain coffee
ICoffee myCoffee = new PlainCoffee();
Console.WriteLine($"{myCoffee.GetDescription()} | Cost: ${myCoffee.GetCost()}");
// Output: Plain Coffee | Cost: $2.00

// 2. Wrap it with Milk
myCoffee = new MilkDecorator(myCoffee);
Console.WriteLine($"{myCoffee.GetDescription()} | Cost: ${myCoffee.GetCost()}");
// Output: Plain Coffee, Milk | Cost: $2.50

// 3. Wrap that exact same bundle with Sugar
myCoffee = new SugarDecorator(myCoffee);
Console.WriteLine($"{myCoffee.GetDescription()} | Cost: ${myCoffee.GetCost()}");
// Output: Plain Coffee, Milk, Sugar | Cost: $2.75

// 4. Want double Sugar? Just wrap it again!
myCoffee = new SugarDecorator(myCoffee);
Console.WriteLine($"{myCoffee.GetDescription()} | Cost: ${myCoffee.GetCost()}");
// Output: Plain Coffee, Milk, Sugar, Sugar | Cost: $3.00
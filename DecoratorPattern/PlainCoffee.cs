// Step 2: Create the Concrete Component
// This is our plain, naked coffee.

public class PlainCoffee : ICoffee
{
    public string GetDescription() => "Planin Coffee";
    public decimal GetCost() => 10.55m;
}
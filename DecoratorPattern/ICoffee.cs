// Step 1: Create the Base Component
// This defines what every beverage can do: give us its description and its cost.
public interface ICoffee
{
    public string GetDescription();
    public decimal GetCost();
}
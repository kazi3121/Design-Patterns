// Step 3: Implement the Concrete Observers (The Apps)
// Let's build two completely different applications that want to display this stock data.

public class MobileAppDisplay : IObserver
{
    public void Update(string stockSymbol, decimal price)
    {
        Console.WriteLine($"[Mobile Notification] {stockSymbol} is now ${price}!");
    }
}
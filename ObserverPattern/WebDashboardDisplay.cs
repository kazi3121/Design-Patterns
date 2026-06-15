// Step 3: Implement the Concrete Observers (The Apps)
// Let's build two completely different applications that want to display this stock data.

public class WebDashboardDisplay : IObserver
{
    public void Update(string stockSymbol, decimal price)
    {
        Console.WriteLine($"[Web Dashboard Widget] Graph updated for {stockSymbol}. Current Value: ${price}");
    }
}
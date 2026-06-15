// Step 2: Implement the Concrete Subject (The Stock Market)
// This class manages the data and keeps track of who is currently subscribed.

public class StockMarket : ISubject
{
    private readonly List<IObserver> _observers = new List<IObserver>();
    private string? _stockSymbol;
    private decimal _price;

    public void UpdateStockPrice(string stockSymbol, decimal price)
    {
        _stockSymbol = stockSymbol;
        _price = price;
        NotifyObservers();
    }

    public void RegisterObserver(IObserver observer) => _observers.Add(observer);
    public void RemoveObserver(IObserver observer) => _observers.Remove(observer);

    public void NotifyObservers()
    {
        foreach (var observer in _observers)
        {
            observer.Update(_stockSymbol, _price);
        }
    }
}
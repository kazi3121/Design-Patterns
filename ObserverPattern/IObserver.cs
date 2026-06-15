// The Listener
public interface IObserver
{
    // This is the method the Subject will call to hand over the new data
    void Update(string stockSymbol, decimal price);
}
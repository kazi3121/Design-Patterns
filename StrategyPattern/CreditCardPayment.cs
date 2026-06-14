public class CreditCardPayment : IPaymentStrategy
{
    private string _cardNumber;
    public CreditCardPayment(string cardNumber) => _cardNumber = cardNumber;

    public void Pay(decimal amount)
    {
        Console.WriteLine($"Successfully paid ${amount} using Credit Card ({_cardNumber}).");
    }
}
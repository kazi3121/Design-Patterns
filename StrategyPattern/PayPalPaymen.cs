public class PayPalPayment : IPaymentStrategy
{
    private string _email;
    public PayPalPayment(string email) => _email = email;

    public void Pay(decimal amount)
    {
        Console.WriteLine($"Successfully paid ${amount} via PayPal account ({_email}).");
    }
}
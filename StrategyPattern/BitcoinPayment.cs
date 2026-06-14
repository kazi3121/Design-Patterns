public class BitcoinPayment : IPaymentStrategy
{
    private string _walletAddress;
    public BitcoinPayment(string walletAddress) => _walletAddress = walletAddress;

    public void Pay(decimal amount)
    {
        Console.WriteLine($"Successfully paid ${amount} using Bitcoin Wallet ({_walletAddress}).");
    }
}
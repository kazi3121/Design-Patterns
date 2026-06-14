public class ShoppingCart
{
    private IPaymentStrategy? _paymentStrategy;
    private decimal totalAmount;

    public void AddTotalAmount(decimal price) => totalAmount += price;

    public void SetStrategy(IPaymentStrategy paymentStrategy) => _paymentStrategy = paymentStrategy;

    public void Checkout()
    {
        if (_paymentStrategy == null) throw new InvalidOperationException("Payment strategy is not set!");

        _paymentStrategy.Pay(totalAmount);
    }
}
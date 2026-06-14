namespace FactoryDesignPattern;

public static class CreditCartFactory
{
    public static ICreditCart GetCreditCart(string type)
    {
        return type.ToLower() switch
        {
            "moneyback" => new MoneyBack(),
            "titanium" => new Titanium(),
            "platinium" => new Platinum(),
            _ => throw new ArgumentException("Invalid notification type")
        };
    }
}
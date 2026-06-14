namespace FactoryDesignPattern;

public class Titanium : ICreditCart
{
    public string GetCardType()
    {
        return "Titanium Edge";
    }
    public int GetCreditLimit()
    {
        return 25000;
    }
    public int GetAnnualCharge()
    {
        return 1500;
    }
}

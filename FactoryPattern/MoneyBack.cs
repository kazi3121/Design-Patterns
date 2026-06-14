namespace FactoryDesignPattern;

class MoneyBack : ICreditCart
{
    public string GetCardType()
    {
        return "MoneyBack";
    }

    public int GetCreditLimit()
    {
        return 15000;
    }

    public int GetAnnualCharge()
    {
        return 500;
    }
}

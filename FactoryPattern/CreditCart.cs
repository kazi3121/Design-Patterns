namespace FactoryDesignPattern
{
    public interface ICreditCart
    {
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();
    }
}
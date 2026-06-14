using FactoryDesignPattern;

ICreditCart creditCart = CreditCartFactory.GetCreditCart("moneyback");

Console.WriteLine(creditCart.GetAnnualCharge());
Console.WriteLine(creditCart.GetCreditLimit());
Console.WriteLine(creditCart.GetCardType());

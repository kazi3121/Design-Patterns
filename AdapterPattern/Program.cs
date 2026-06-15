
// 1. Your client app generates its standard JSON data
string clientJsonPayload = "{ \"CustomerId\": 101, \"Status\": \"Active\" }";

// 2. Instantiate the incompatible third-party class
LegacyXmlBillingSystem legacySystem = new LegacyXmlBillingSystem();

// 3. Plug the legacy system into our Adapter
IJsonBillingTarget adapter = new BillingAdapter(legacySystem);

// 4. The application processes billing using its native JSON layout
// The client code doesn't even know XML exists!
adapter.ProcessBillingObject(clientJsonPayload);


// var adapter = new Adapter(new LegacyPaymentSystem());
// adapter.ProcessPayment(50.50m);
// public interface IProcessPayment
// {
//     public void ProcessPayment(decimal amount)
//     {

//     }
// }

// public class LegacyPaymentSystem
// {
//     public void MakePayment(decimal amount)
//     {
//         Console.WriteLine($"payment is processed via Leagacy Payment System: {amount} usd");
//     }
// }

// public class Adapter : IProcessPayment
// {
//     private LegacyPaymentSystem? _legacyPaymentSystem;

//     public Adapter(LegacyPaymentSystem legacyPaymentSystem) => _legacyPaymentSystem = legacyPaymentSystem;

//     public void ProcessPayment(decimal amount)
//     {
//         _legacyPaymentSystem.MakePayment(amount);
//     }
// }
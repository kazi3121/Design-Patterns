// Step 2: The Adaptee(The incompatible third-party system)
// This is the external legacy service. It has the math we need, but it strictly requires XML data.

// The Incompatible Third-Party Class
public class LegacyXmlBillingSystem
{
    public void RenderXmlInvoice(string xmlCustomerData)
    {
        Console.WriteLine("--- Third Party Legacy System Processing ---");
        Console.WriteLine($"Validating XML Format:\n{xmlCustomerData}");
        Console.WriteLine("Fraud check passed successfully.");
    }
}
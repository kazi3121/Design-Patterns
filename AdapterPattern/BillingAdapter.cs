// Step 3: The Adapter(The Middleman)
// The Adapter implements our expected IJsonBillingTarget interface so our application can call it seamlessly. Internally,
// it holds a reference to the LegacyXmlBillingSystem and does the heavy lifting of converting JSON to XML.

public class BillingAdapter : IJsonBillingTarget
{
    private readonly LegacyXmlBillingSystem _legacySystem;

    public BillingAdapter(LegacyXmlBillingSystem legacySystem)
    {
        _legacySystem = legacySystem;
    }

    public void ProcessBillingObject(string jsonCustomerData)
    {
        Console.WriteLine("[Adapter] Received JSON data from Client application.");

        // 1. Convert JSON string to XML string (Simulated conversion logic)
        Console.WriteLine("[Adapter] Converting JSON payload to XML payload...");
        string xmlConvertedData = ConvertJsonToXml(jsonCustomerData);

        // 2. Delegate the converted payload to the legacy service
        _legacySystem.RenderXmlInvoice(xmlConvertedData);
    }

    private string ConvertJsonToXml(string json)
    {
        // Simple manual translation for example purposes
        // In reality, you might use libraries like Newtonsoft.Json
        return $"<customer><name>John Doe</name><jsonSource>{json.Replace("\"", "'")}</jsonSource></customer>";
    }
}
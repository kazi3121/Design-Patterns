// Step 1: The Target(What our application expects)
// Our application expects everything to work with a standard IJsonBillingTarget interface.

public interface IJsonBillingTarget
{
    // Our system works exclusively with JSON strings
    void ProcessBillingObject(string jsonCustomerData);
}
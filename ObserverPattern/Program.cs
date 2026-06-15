// Step 4: See It In Action (Usage)
// Look at how cleanly subscribers can attach and detach from the publisher dynamically at runtime.

// 1. Create our central broadcaster (Subject)
StockMarket stockMarket = new StockMarket();

// 2. Create our display apps (Observers)
MobileAppDisplay mobileApp = new MobileAppDisplay();
WebDashboardDisplay webDashboard = new WebDashboardDisplay();

// 3. Apps subscribe to the stock market
stockMarket.RegisterObserver(mobileApp);
stockMarket.RegisterObserver(webDashboard);

// 4. Simulate a price change
Console.WriteLine("--- First Price Change ---");
stockMarket.UpdateStockPrice("MSFT", 420.50m);
// Output: Both Mobile and Web will print their respective updates!

Console.WriteLine("\n--- Second Price Change ---");
stockMarket.UpdateStockPrice("AAPL", 180.25m);

// 5. Mobile App user unsubscribes (turns off notifications)
stockMarket.RemoveObserver(mobileApp);

Console.WriteLine("\n--- Third Price Change (Mobile Unsubscribed) ---");
stockMarket.UpdateStockPrice("TSLA", 175.00m);
// Output: ONLY the Web Dashboard will print an update this time!


// Why this is beautiful
// The StockMarket class doesn't know anything about MobileAppDisplay or WebDashboardDisplay. It only knows about the IObserver interface.

// Tomorrow, if you want to add an EmailAlertSystem, a CryptoTradingBot, or an SMSAlertSystem,
// you can do it without changing a single line of code inside the StockMarket class. You just create the new class, 
// implement IObserver, and register it!

// How does this workflow feel to you? Ready to break this down further,
// or do you want to dive straight into how C# natively builds this pattern using Events and Delegates?
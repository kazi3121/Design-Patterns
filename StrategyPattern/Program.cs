var cart = new ShoppingCart();

cart.AddTotalAmount(50.75m);
cart.AddTotalAmount(9.25m);

cart.SetStrategy(new CreditCardPayment("123-456"));
cart.Checkout();

cart.SetStrategy(new PayPalPayment("amin@gmail.com"));
cart.Checkout();

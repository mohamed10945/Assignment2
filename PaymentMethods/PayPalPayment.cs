public class PayPalPayment : IPaymentStrategy
{
    public void ProcessPayment(decimal amount)
    {
        // Logic for processing PayPal payment
        Console.WriteLine($"Processing PayPal payment of {amount:C}.");
    }
}

public class CreditCardPayment : IPaymentStrategy
{
    public void ProcessPayment(decimal amount)
    {
        // Logic for processing credit card payment
        Console.WriteLine($"Processing credit card payment of {amount:C}.");
    }
}

public class BankTransferPayment : IPaymentStrategy
{
    public void ProcessPayment(decimal amount)
    {
        // Logic for processing bank transfer
        Console.WriteLine($"Processing bank transfer payment of {amount:C}.");
    }
}

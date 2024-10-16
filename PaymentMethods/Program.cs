namespace PaymentMethods;

class Program
{
    static void Main(string[] args)
    {
         Console.WriteLine("Select payment method: \n1. Credit Card \n2. Bank Transfer \n3. PayPal");
        string choice = Console.ReadLine();
        
        IPaymentStrategy paymentMethod = null;
        
        switch (choice)
        {
            case "1":
                paymentMethod = new CreditCardPayment();
                break;
            case "2":
                paymentMethod = new BankTransferPayment();
                break;
            case "3":
                paymentMethod = new PayPalPayment();
                break;
            default:
                Console.WriteLine("Invalid choice.");
                return;
        }
        
        PaymentProcessor processor = new PaymentProcessor(paymentMethod);
        processor.ProcessPayment(100); 
    }
}

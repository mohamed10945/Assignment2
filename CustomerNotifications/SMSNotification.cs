public class SMSNotification : INotificationStrategy
{
    public void Send(string message)
    {
        // Logic to send SMS
        Console.WriteLine($"Sending SMS: {message}");
    }
}

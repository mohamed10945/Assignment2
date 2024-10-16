public class EmailNotification : INotificationStrategy
{
    public void Send(string message)
    {
        // Logic to send an email
        Console.WriteLine($"Sending Email: {message}");
    }
}

public class PushNotification : INotificationStrategy
{
    public void Send(string message)
    {
        // Logic to send a push notification
        Console.WriteLine($"Sending Push Notification: {message}");
    }
}

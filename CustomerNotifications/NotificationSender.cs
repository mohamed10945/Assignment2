public class NotificationSender
{
    private INotificationStrategy _notificationStrategy;

    // Constructor that accepts the strategy to be used
    public NotificationSender(INotificationStrategy notificationStrategy)
    {
        _notificationStrategy = notificationStrategy;
    }

    // Method to send the notification
    public void Notify(string message)
    {
        _notificationStrategy.Send(message);
    }
}

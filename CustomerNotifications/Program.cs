namespace CustomerNotifications;

class Program
{
    static void Main(string[] args)
    {
        // Simulate choosing different types of notifications
        INotificationStrategy notification = null;

        Console.WriteLine("Select notification method: \n1. Email \n2. SMS \n3. Push Notification");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                notification = new EmailNotification();
                break;
            case "2":
                notification = new SMSNotification();
                break;
            case "3":
                notification = new PushNotification();
                break;
            default:
                Console.WriteLine("Invalid choice.");
                return;
        }

        NotificationSender sender = new NotificationSender(notification);
        sender.Notify("Your order has been processed!");


    }
}

namespace MediaPlayerPlugins;

class Program
{
    static void Main(string[] args)
    {
       IMedia media = null;

        Console.WriteLine("Select media type: \n1. Audio \n2. Video \n3. Podcast");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                media = new Audio();
                break;
            case "2":
                media = new Video();
                break;
            case "3":
                media = new Podcast();
                break;
            default:
                Console.WriteLine("Invalid choice.");
                return;
        }

        MediaPlayer player = new MediaPlayer(media);
        player.PlayMedia();
        player.StopMedia();

    }
}

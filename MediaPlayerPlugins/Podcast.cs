public class Podcast : IMedia
{
    public void Play()
    {
        Console.WriteLine("Playing podcast...");
    }

    public void Stop()
    {
        Console.WriteLine("Stopping podcast...");
    }
}

public class Audio : IMedia
{
    public void Play()
    {
        Console.WriteLine("Playing audio...");
    }

    public void Stop()
    {
        Console.WriteLine("Stopping audio...");
    }
}

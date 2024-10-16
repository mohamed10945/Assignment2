public class Video : IMedia
{
    public void Play()
    {
        Console.WriteLine("Playing video...");
    }

    public void Stop()
    {
        Console.WriteLine("Stopping video...");
    }
}

public abstract class Vehicle
{
    public void Start()
    {
        Console.WriteLine("The vehicle is starting.");
    }

    public void Stop()
    {
        Console.WriteLine("The vehicle is stopping.");
    }

    public abstract void Describe();
}


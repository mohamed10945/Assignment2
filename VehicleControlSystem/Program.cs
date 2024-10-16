namespace VehicleControlSystem;

class Program
{
    static void Main(string[] args)
    {
        Vehicle[] vehicles = new Vehicle[]
        {
            new Car(),
            new Truck(),
            new Motorcycle()
        };

        
        foreach (Vehicle vehicle in vehicles)
        {
            vehicle.Start();
            vehicle.Describe();
            vehicle.Stop();
            Console.WriteLine(); 
        }

    }
}

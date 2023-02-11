class Vehicle
{
    private string name;
    private string color;

    public void Descibe()
    {
        Console.WriteLine("Vehicle Class");
    }

    public string Name
    {
        get => name;
        set => name = value;
    }

    public string Color
    {
        get => color;
        set => color = value;
    }
}

class MainClass
{
    static void Main(string[] args)
    {
        Vehicle vehicle = new Vehicle();
        vehicle.Name = "Toyota";
        vehicle.Color = "White";
        
        vehicle.Descibe();
        
        Console.WriteLine(vehicle.Name);
        Console.WriteLine(vehicle.Color);
    }
}
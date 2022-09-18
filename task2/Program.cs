Car car1 = new("Zigul", "MB-700", "300");
Car car2 = new("Panamera", "KLM1", "200");
var car3 = car1;
Console.WriteLine($"car1.Equals(car3) = {car1.Equals(car3)}");
CarsCatalog cars = new(car1, car2, car3);
Console.WriteLine($"cars[1] = {cars[1]}");

internal class Car
{
    public string Name { set; get;}
    public string Engine { set; get;}
    private string MaxSpeed { set; get;}

    public Car(string name, string engine, string maxSpeed)
    {
        Name = name;
        Engine = engine;
        MaxSpeed = maxSpeed;
    }
    
    public override string ToString()
    {
        return Name;
    }

    public bool Equals(Car other)
    {
        return Name == other.Name && Engine == other.Engine && MaxSpeed == other.MaxSpeed;
    }
    
    public static bool IsIn<Car>(Car what, Car[] obs) where Car : IEquatable<Car> {
        foreach(var v in obs)
            if(v.Equals(what))
                return true;
        return false;
    }
}

internal class CarsCatalog
{
    private readonly Car[] _cars;

    public CarsCatalog(params Car[] cars)
    {
        _cars = cars;
    }
    
    public string this[uint index] => $"{_cars[index].Name} {_cars[index].Engine}";
}

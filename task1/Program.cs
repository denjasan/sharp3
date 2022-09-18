Vector v1 = new(1, 1, 1);
Vector v2 = new(3, 4, 5);
var v3 = v1 + v2;
Console.WriteLine($"v1 + v2: x = {v3._x}; y = {v3._y}; z = {v3._z}");
Console.WriteLine($"v1 * v2 = {v1 * v2}");
v3 = v1 * 2;
Console.WriteLine($"v1 * 2: x = {v3._x}; y = {v3._y}; z = {v3._z}");
Console.WriteLine($"v1 != v2 = {v1 != v2}");
Console.WriteLine($"v1 > v2 = {v1 > v2}");

internal class Vector
{
    public double _x;
    public double _y;
    public double _z;

    public Vector(double x, double y, double z)
    {
        _x = x;
        _y = y;
        _z = z;
    }

    private double Len()
    {
        return Math.Sqrt(_x * _x + _y * _y + _z * _z);
    }

    public static Vector operator +(Vector v1, Vector v2)
    {
        return new Vector(v1._x + v2._x, v1._y + v2._y, v1._z + v2._z);
    }

    public static double operator *(Vector v1, Vector v2)
    {
        return v1._x * v2._x + v1._y * v2._y + v1._z * v2._z;
    }
    
    public static Vector operator *(Vector v1, double num)
    {
        return new Vector(v1._x * num, v1._y * num, v1._z * num);
    }

    public static bool operator ==(Vector v1, Vector v2)
    {
        return Equals(v1.Len(), v2.Len());
    }

    public static bool operator !=(Vector v1, Vector v2)
    {
        return !Equals(v1.Len(), v2.Len());
    }

    public static bool operator >(Vector v1, Vector v2)
    {
        return v1.Len() > v2.Len();
    }
    
    public static bool operator <(Vector v1, Vector v2)
    {
        return v1.Len() < v2.Len();
    }
}

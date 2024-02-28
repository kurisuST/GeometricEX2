using GeometricEX2;

public delegate double MathOps(double a, double b);
class Program
{
    static void Main(string[] args)
    {
        Triangle triangle = new Triangle(5, 4);
        Console.WriteLine($"The Triangle area is: {triangle.GetArea()}");
        double add = GeometricEX2.MathOps.Addition(3, 4);
        Console.WriteLine($"The addition about 3 and 4 is: {add}");
        double perimeter = GeoOps.Perimeter(3, 4, 5);
        Console.WriteLine($"The perimeter is: {perimeter}");
        double number = 5;
        Console.WriteLine($"The double of {number} is: {number.DupleE()}");
        MathOps operation = (a, b) => a * b;
        Console.WriteLine($"The operation result about 3 * 4 is: {operation(3, 4)}");
    }
}
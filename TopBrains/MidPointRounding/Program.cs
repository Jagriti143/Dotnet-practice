using System;

public class Program
{
    public static double Area(double radius)
    {
        double pii=Math.PI;
        double area=pii*radius*radius;
        return area;
    }
    public static void Main(string[] args)
    {
        double radius=double.Parse(Console.ReadLine());
        double area=Math.Round(Area(radius),2,MidpointRounding.AwayFromZero);
        Console.WriteLine(area);
    }
}

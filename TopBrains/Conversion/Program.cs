using System;
public class Program
{
    public static void Main(string[] args)
    {
        int foot=int.Parse(Console.ReadLine());
        double centi=Math.Round(foot*30.48,2,MidpointRounding.AwayFromZero);
        Console.WriteLine(centi);
    }
}

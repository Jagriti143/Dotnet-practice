using System;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Height: ");
        int height=int.Parse(Console.ReadLine());
        if (height < 150)
        {
            Console.WriteLine("Short");
        }else if(height>=150 && height < 180)
        {
            Console.WriteLine("Average");
        }
        else
        {
            Console.WriteLine("Tall");
        }
    }
}

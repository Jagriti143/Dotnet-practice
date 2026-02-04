using System;
using System.Diagnostics;
using System.Text;
public class Program
{
    public static void Main(string[] args)
    {
        int sec=int.Parse(Console.ReadLine());
        double ot=(double)sec/60;
        StringBuilder s=new StringBuilder();
        s.Append(ot.ToString("F2"));
        s.Replace(".",":");
        Console.WriteLine(s);

    }
}

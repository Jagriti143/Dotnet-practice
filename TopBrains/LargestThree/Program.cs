using System;
public class Program
{
    public static int Largest(int a,int b,int c)
    {
        if(a>b && a > c)
        {
            return a;
        }else if(b>a && b > c)
        {
            return b;
        }else{
            return c;
        }
        return 0;

    }
    public static void Main(string[] args)
    {
        int l=Largest(9,4,2);
        Console.WriteLine(l);
    }
}

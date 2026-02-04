using System;
public class Program
{
    public static void Main(string[] args)
    {
        int n=int.Parse(Console.ReadLine());
        int[] arr=new int[n];
        int num=int.Parse(Console.ReadLine());
        for(int i = 0; i <arr.Length; i++)
        {
            arr[i]=num*(i+1);
            Console.WriteLine(arr[i]);
        }
        

    }
}

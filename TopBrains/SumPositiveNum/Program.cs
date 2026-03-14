using System;
public class Program
{
    public static void Main(string[] args)
    {
        int n=6;
        int[] arr=new int[n];
        for(int i = 0; i < arr.Length; i++)
        {
            arr[i]=int.Parse(Console.ReadLine());
        }
        int sum=0;
        for(int i = 0; i < arr.Length; i++)
        {
            
            if (arr[i] == 0)
                break;
            
            if (arr[i] < 0)
                continue;
            
            sum+=arr[i];
        }
        Console.WriteLine(sum);
    }
}

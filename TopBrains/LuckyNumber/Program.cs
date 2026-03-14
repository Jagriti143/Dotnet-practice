using System;
class Program
{
    public static int Sum(int a)
    {
        int sum=0;
        while (a > 0)
        {
            sum+=a%10;
            a=a/10;
        }
        return sum;
    }
    public static void Main(string[] args)
    {
        int cnt=0;
        for(int i = 20; i <= 30; i++)
        {
            if ((Sum(i) * Sum(i))==Sum(i*i))
            {
                cnt++;
            }
        }
        Console.WriteLine(cnt);

    }
}

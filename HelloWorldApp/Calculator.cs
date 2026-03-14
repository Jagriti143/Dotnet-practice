using System;
namespace Calculator
{
class Cal{
    int num1;
    int num2;
    int result;
    public void Add(){
        Console.WriteLine("Enter num1: ");
        num1=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter num2: ");
        num2=Convert.ToInt32(Console.ReadLine());
        result=num1+num2;
        Console.WriteLine($"Sum of Numbers: {result}");
    }
    public void Sub(){
        Console.WriteLine("Enter num1: ");
        num1=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter num2: ");
        num2=Convert.ToInt32(Console.ReadLine());
        result=num1-num2;
        Console.WriteLine($"Subtraction of Numbers: {result}");
    }
    public void Mul(){
        Console.WriteLine("Enter num1: ");
        num1=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter num2: ");
        num2=Convert.ToInt32(Console.ReadLine());
        result=num1*num2;
        Console.WriteLine($"Multiplication of Numbers: {result}");
    }
    public void Div(){
        Console.WriteLine("Enter num1: ");
        num1=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter num2: ");
        num2=Convert.ToInt32(Console.ReadLine());
        result=num1/num2;
        Console.WriteLine($"Division of Numbers: {result}");
    }
    public void Mod(){
        Console.WriteLine("Enter num1: ");
        num1=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter num2: ");
        num2=Convert.ToInt32(Console.ReadLine());
        result=num1%num2;
        Console.WriteLine($"Division of Numbers: {result}");
    }
}
}
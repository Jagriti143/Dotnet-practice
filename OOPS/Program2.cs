using System;
class Mainclass{
    public static void Main(string[] args){

        Calculator c=new Calculator();
        c.calculate();
        //Calculator(10,5);
    //     Example();
    // void Example()
    // {
    // int Square(int x)
    // {
    //     return x * x;
    // }
    // Func<int, int> cube = x => x*x*x;
    // Func<int, int> squareLambda = x => x * x;

    // Console.WriteLine(Square(4));
    // Console.WriteLine(squareLambda(4));
    // Console.WriteLine(cube(4));
    // }

    }
    class Calculator
{ 
    static int a = 4;
    static int b = 5;
    static int num = 6;
    public void calculate()
    {

        static int add(int a, int b)
        {
            Console.WriteLine(num);
            return a + b;
        }

        int addition = add(a, b);
        Console.WriteLine("Addition of a and b: " + addition);
    }
}
//    public static void Calculator(int a ,int b){
//     void Add(){
//             Console.WriteLine(a+b);
//         }
//         void Subtract(){
//             Console.WriteLine(a-b);
//         }
//         Add();
//         Subtract();
           // }
}
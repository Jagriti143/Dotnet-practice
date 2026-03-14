using System;
using System.Reflection;

class Program
{
    static void Main()
    {
        Assembly asm = Assembly.LoadFrom(
            @"C:\Users\Jagriti\Desktop\.net practice\MyLibrary\bin\Debug\net10.0\MyLibrary.dll"
        );

        foreach (Type t in asm.GetTypes())
        {
            Console.WriteLine("Type: " + t.Name);

            foreach (MethodInfo m in t.GetMethods())
            {
                Console.WriteLine("   Method: " + m.Name);
            }

            Console.WriteLine();
        }
    }
}


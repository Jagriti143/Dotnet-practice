using System;
using LogProcessing;

class MainClass
{
    public static void Main(string[] args)
    {
        LogParser parser = new LogParser();

       
        Console.WriteLine("Task 1: Validate Log Line Format");
        Console.WriteLine("Input Log Line\t\t\tOutput");

        string[] task1Inputs =
        {
            "[INF] Application started",
            "[ERR] Database connection failed",
            "[WRN] Low memory warning",
            "INF Application started",
            "[INFO] Application started",
            "[ABC] Unknown message"
        };

        foreach (string line in task1Inputs)
        {
            bool isValid = parser.IsValidLine(line);
            Console.WriteLine($"{line}\t{isValid.ToString().ToLower()}");
        }

        Console.WriteLine();


       
        Console.WriteLine("Task 2: Split Log Line Using Delimiters");

        string task2Input =
            "[INF] User login<***>Session created<====>Access granted";

        string[] task2Output = parser.SplitLogLine(task2Input);

        Console.WriteLine("Input:");
        Console.WriteLine(task2Input);
        Console.WriteLine("Output:");
        Console.WriteLine("[");

        for (int i = 0; i < task2Output.Length; i++)
        {
            Console.WriteLine($"  \"{task2Output[i]}\"{(i < task2Output.Length - 1 ? "," : "")}");
        }

        Console.WriteLine("]");
        Console.WriteLine();


        
        Console.WriteLine("Task 3: Count Quoted Password Occurrences");

        string task3Input =
            "User said \"password123 is weak\"\n" +
            "Admin noted \"PASSWORD456 expired\"\n" +
            "No issue found";

        int task3Output = parser.CountQuotedPasswords(task3Input);

        Console.WriteLine("Input:");
        Console.WriteLine(task3Input);
        Console.WriteLine("Output:");
        Console.WriteLine(task3Output);
        Console.WriteLine();


      
        Console.WriteLine("Task 4: Remove End-of-Line Markers");

        string task4Input =
            "Transaction completed successfully end-of-line456";

        string task4Output = parser.RemoveEndOfLineText(task4Input);

        Console.WriteLine("Input:");
        Console.WriteLine(task4Input);
        Console.WriteLine("Output:");
        Console.WriteLine(task4Output);
        Console.WriteLine();


       
        Console.WriteLine("Task 5: Identify and Label Weak Passwords");

        string[] task5Input =
        {
            "User entered password123 during login",
            "System startup completed",
            "Admin reset passwordABC",
            "Backup process finished"
        };

        string[] task5Output = parser.ListLinesWithPasswords(task5Input);

        Console.WriteLine("Input:");
        foreach (string line in task5Input)
            Console.WriteLine(line);

        Console.WriteLine("Output:");
        Console.WriteLine("{");

        for (int i = 0; i < task5Output.Length; i++)
        {
            Console.WriteLine($"  \"{task5Output[i]}\"{(i < task5Output.Length - 1 ? "," : "")}");
        }

        Console.WriteLine("}");
    }
}

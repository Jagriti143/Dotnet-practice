using System;
using System.Collections;
using System.Collections.Generic;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("TASK 1: PRODUCT PRICE ANALYSIS");

        Console.Write("Enter number of products: ");
        int n = int.Parse(Console.ReadLine());

        int[] prices = new int[n];

        Console.WriteLine("Enter product prices:");
        for (int i = 0; i < n; i++)
        {
            int price = int.Parse(Console.ReadLine());
            if (price > 0)
                prices[i] = price;
            else
            {
                Console.WriteLine("Price must be positive. Re-enter:");
                i--;
            }
        }

        int sum = 0;
        for (int i = 0; i < n; i++)
            sum += prices[i];

        double avg = (double)sum / n;
        Console.WriteLine($"Average Price: {avg}");

        Array.Sort(prices);

        for (int i = 0; i < n; i++)
            if (prices[i] < avg)
                prices[i] = 0;

        Array.Resize(ref prices, prices.Length + 5);
        for (int i = n; i < prices.Length; i++)
            prices[i] = (int)avg;

        Console.WriteLine("Final Product Price Array:");
        for (int i = 0; i < prices.Length; i++)
            Console.WriteLine($"Index {i} → {prices[i]}");


        Console.WriteLine("\nTASK 2: BRANCH SALES ANALYSIS");

        Console.Write("Enter number of branches: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Enter number of months: ");
        int m = int.Parse(Console.ReadLine());

        int[,] sales = new int[b, m];

        Console.WriteLine("Enter sales data:");
        for (int i = 0; i < b; i++)
            for (int j = 0; j < m; j++)
                sales[i, j] = int.Parse(Console.ReadLine());

        int globalMax = 0;

        for (int i = 0; i < b; i++)
        {
            int branchTotal = 0;
            int branchMax = 0;

            for (int j = 0; j < m; j++)
            {
                branchTotal += sales[i, j];
                branchMax = Math.Max(branchMax, sales[i, j]);
            }

            Console.WriteLine($"Branch {i} Total Sales: {branchTotal}");
            Console.WriteLine($"Branch {i} Highest Sale: {branchMax}");
            globalMax = Math.Max(globalMax, branchMax);
        }

        Console.WriteLine($"Global Highest Sale: {globalMax}");

        Console.WriteLine("\nTASK 3: JAGGED ARRAY EXTRACTION");

        int[][] jagged = new int[b][];

        for (int i = 0; i < b; i++)
        {
            int count = 0;
            for (int j = 0; j < m; j++)
                if (sales[i, j] >= avg)
                    count++;

            jagged[i] = new int[count];
            int index = 0;

            for (int j = 0; j < m; j++)
                if (sales[i, j] >= avg)
                    jagged[i][index++] = sales[i, j];
        }

        Console.WriteLine("Filtered Jagged Array:");
        for (int i = 0; i < jagged.Length; i++)
        {
            Console.Write($"Branch {i}: ");
            for (int j = 0; j < jagged[i].Length; j++)
                Console.Write(jagged[i][j] + " ");
            Console.WriteLine();
        }

        Console.WriteLine("\nTASK 4: CUSTOMER TRANSACTION CLEANING");

        Console.Write("Enter number of customer transactions: ");
        int t = int.Parse(Console.ReadLine());

        List<int> customers = new List<int>();

        Console.WriteLine("Enter customer IDs:");
        for (int i = 0; i < t; i++)
            customers.Add(int.Parse(Console.ReadLine()));

        HashSet<int> uniqueCustomers = new HashSet<int>(customers);
        List<int> cleanedList = new List<int>(uniqueCustomers);

        Console.WriteLine("Cleaned Customer IDs:");
        foreach (int id in cleanedList)
            Console.Write(id + " ");

        Console.WriteLine($"\nDuplicates Removed: {customers.Count - cleanedList.Count}");

        Console.WriteLine("\nTASK 5: FINANCIAL TRANSACTION FILTERING");

        Console.Write("Enter number of transactions: ");
        int tr = int.Parse(Console.ReadLine());

        Dictionary<int, double> transactions = new Dictionary<int, double>();

        for (int i = 0; i < tr; i++)
        {
            Console.Write("Transaction ID: ");
            int id = int.Parse(Console.ReadLine());

            if (transactions.ContainsKey(id))
            {
                Console.WriteLine("Duplicate ID not allowed.");
                i--;
                continue;
            }

            Console.Write("Amount: ");
            double amount = double.Parse(Console.ReadLine());
            transactions.Add(id, amount);
        }

        SortedList<int, double> highValue = new SortedList<int, double>();

        foreach (var kv in transactions)
            if (kv.Value >= avg)
                highValue.Add(kv.Key, kv.Value);

        Console.WriteLine("High Value Transactions:");
        foreach (var kv in highValue)
            Console.WriteLine($"ID: {kv.Key}, Amount: {kv.Value}");

        Console.WriteLine("\nTASK 6: PROCESS FLOW MANAGEMENT");

        Console.Write("Enter number of operations: ");
        int op = int.Parse(Console.ReadLine());

        Queue<string> processQueue = new Queue<string>();
        Stack<string> undoStack = new Stack<string>();

        Console.WriteLine("Enter operations:");
        for (int i = 0; i < op; i++)
        {
            string operation = Console.ReadLine();
            processQueue.Enqueue(operation);
            undoStack.Push(operation);
        }

        Console.WriteLine("Processing Operations:");
        while (processQueue.Count > 0)
            Console.WriteLine(processQueue.Dequeue());

        Console.WriteLine("Undo Operations:");
        for (int i = 0; i < 2 && undoStack.Count > 0; i++)
            Console.WriteLine(undoStack.Pop());

        Console.WriteLine("\nTASK 7: LEGACY DATA RISK DEMONSTRATION");

        Console.Write("Enter number of users: ");
        int u = int.Parse(Console.ReadLine());

        Hashtable users = new Hashtable();
        ArrayList mixedData = new ArrayList();

        for (int i = 0; i < u; i++)
        {
            Console.Write("Username: ");
            string name = Console.ReadLine();

            Console.Write("Role: ");
            string role = Console.ReadLine();

            users[name] = role;
            mixedData.Add(name);
            mixedData.Add(role);
        }

        Console.WriteLine("Hashtable Data:");
        foreach (DictionaryEntry entry in users)
            Console.WriteLine($"{entry.Key} → {entry.Value}");

        Console.WriteLine("ArrayList Data (Mixed Types):");
        foreach (var item in mixedData)
            Console.WriteLine(item);

        Console.WriteLine("Risk: ArrayList allows mixed data causing runtime casting issues.");
    }
}




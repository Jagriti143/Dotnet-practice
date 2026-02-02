using System;

class Program
{
    public decimal Balance { get; private set; }

    public Program(decimal initialBalance)
    {
        Balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount < 0)
            throw new Exception("Deposit amount cannot be negative");

        Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount > Balance)
            throw new Exception("Insufficient funds.");

        Balance -= amount;
    }

    static void Main()
    {
        Program account1 = new Program(1000);
        account1.Deposit(500);
        Console.WriteLine("Test Case 1 - Expected: 1500, Actual: " + account1.Balance);

        Program account2 = new Program(1000);
        try
        {
            account2.Deposit(-200);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Test Case 2 - Expected: Deposit amount cannot be negative, Actual: " + ex.Message);
        }

        Program account3 = new Program(1000);
        account3.Withdraw(300);
        Console.WriteLine("Test Case 3 - Expected: 700, Actual: " + account3.Balance);

        Program account4 = new Program(500);
        try
        {
            account4.Withdraw(800);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Test Case 4 - Expected: Insufficient funds., Actual: " + ex.Message);
        }
    }
}


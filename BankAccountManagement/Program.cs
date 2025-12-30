using System;
using System.IO;
using BankingSystem;
class MainClass
{
    private static void LogException(Exception ex)
    {
        File.AppendAllText("error.log", DateTime.Now +" | " +ex.GetType().Name+" | "+ ex.Message+Environment.NewLine);
    }
    public static void Main(string[] args)
    {
        try
        {
            BankAccount b=new BankAccount("123",100);
            int amt=5000;
            b.Withdraw(amt);
        }
        catch(InsufficientBalanceException ex)
        {
            Console.WriteLine(ex.Message);
            LogException(ex);
        }
        catch(FormatException ex)
        {
            Console.WriteLine(ex.Message);
            LogException(ex);
        }
        catch(BankOperationException ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.InnerException.Message);
            LogException(ex);
        }
        catch(Exception ex)
        {
            Console.WriteLine("Any other exception occured");
            LogException(ex);
        }

    }
}

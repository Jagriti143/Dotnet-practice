using System;
namespace BankingSystem
{
    class InsufficientBalanceException:Exception{
    public InsufficientBalanceException(string message):base(message){ }
}
    class BankOperationException : Exception
    {
        public BankOperationException(string message,Exception innerException) : base(message, innerException){}
    }
    class BankAccount
    {
        public string acctnum{get; private set;}
        public decimal bal{get; private set;}

        public BankAccount(string a,decimal initialbalance)
        {
            if (string.IsNullOrWhiteSpace(a))
            {
                throw new ArgumentException("Invalid Input");
            }
            if (initialbalance < 0)
            {
                throw new ArgumentException("Invalid Account Number");
            }
            this.acctnum=a;
            this.bal=initialbalance;
           
        }

        public void Withdraw(decimal amt)
        {
            try{
                if (amt < 0)
                {
                    throw new FormatException("Amount cannot be negative");
                }
                if (amt > bal)
                {
                    throw new InsufficientBalanceException("Amount exceeds current balance. Invalid input");
                }
                else
                {
                   bal-=amt;
                    Console.WriteLine($"Balance deducted successfully.Balance Remaining: {bal:C}");
                }
            
            }
            catch(Exception ex)
            {
                throw new BankOperationException("An error occurred during withdrawal operation",ex);
            }
        }


        }
        
    }

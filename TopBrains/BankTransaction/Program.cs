using System;
public class Bank
{
    public int Amount{get;set;}
   
    public int Deposit(int balance)
    {
        
        Amount+=balance;
        
        return Amount;
    }
    public int Withdraw(int balance)
    {
       
            if(Amount>=balance){
            Amount-=balance;
            }
        
        return Amount;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Bank b=new Bank();
        int i=1000;
        b.Amount=i;
        int[] t={500, -200, -1500, 300};
       foreach(int a in t){
        if(a>=0){
            b.Deposit(a);
            }
            else
            {
                b.Withdraw(-a);
            }
       }
       Console.WriteLine(b.Amount);
    }
}

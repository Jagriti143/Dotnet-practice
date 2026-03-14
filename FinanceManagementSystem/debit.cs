using System;
namespace Debitdetails{
    class Debit{
        public void Atm(){
            Console.WriteLine("Enter the amount: ");
            int amount=Convert.ToInt32(Console.ReadLine());
            int limit=40000;
            if(amount<=limit){
                Console.WriteLine("Withdrawal permitted within daily limit.");
            }else{
                Console.WriteLine("Daily ATM withdrawal limit exceeded.");
            }
        }
        public void Emi(){
            Console.WriteLine("Enter Montly income: ");
            int income=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter EMI amount: ");
            float emiamount=Convert.ToSingle(Console.ReadLine());
            if(emiamount<=0.4){
                Console.WriteLine("EMI is financially manageable.");
            }else{
                Console.WriteLine("EMI exceeds safe income limit.");
            }

        }
        public void Trans(){
            Console.WriteLine("Number of Transactions: ");
            int trans=Convert.ToInt32(Console.ReadLine());
            int sum=0;
            for(int i=0;i<trans;i++){
                Console.WriteLine($"Enter amount for transaction {i + 1}: ");
                int amt = Convert.ToInt32(Console.ReadLine());
                sum += amt;
            }
            Console.WriteLine($"Total debit amount for the day: Rs.{sum}");

        }
        public void Bal(){
            Console.WriteLine("Current Balance: ");
            int bal=Convert.ToInt32(Console.ReadLine());
            if(bal<2000){
                Console.WriteLine("Minimum balance not maintained. Penalty applicable.");
            }else{
                Console.WriteLine("Minimum balance requirement satisfied.");
            }
        }
    }
}
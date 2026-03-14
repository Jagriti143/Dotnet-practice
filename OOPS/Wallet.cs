using System;
namespace Walletdata{
    class Wallet{
        private double balance=0;
        public void putMoney(double amount){
            balance+=amount;
        }
        public void AddMoney(double amount){

            Console.WriteLine($"{amount} Amount is added to balance:{balance}");
            balance+=amount;

        }
        public double Getbalance(){
            return balance;
        }
       
    }
}
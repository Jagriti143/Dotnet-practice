// using System;
// using Walletdata;
// using Mathops;
// class Mainclass{
//     public static void Main(string[] args){
//         // Maths m=new Maths();
//         // Console.WriteLine(Maths.Add(1,2));
//         // Console.WriteLine($"{m.Add(1.1,2.911):F2}");
//         // m.Person("name",09,"city",'F');
//         // int q,r;
//         // Mulcal(10,2,out q, out r);
//         // Console.WriteLine($"Q: {q} , R:{r}");

//         // void Print(in int x)
//         // {
//         // Console.WriteLine(x);
//         // }
//         // int num = 50;
//         // Print(in num);

//         // int x=10;
//         // void increment(ref int a){
//         // a=a+10;
//         // }
//         // increment(ref x);
//         // Console.WriteLine(x);
//         Console.WriteLine(sum(1,2,3,4));

//         // string name="JAGRITI";
//         // char[] arr=name.ToCharArray();
//         // foreach(char i in arr){
//         //     Console.WriteLine(i);
//         // }

       
//         // Wallet w=new Wallet();
//         // w.putMoney(60000);
//         // w.AddMoney(569);
//         // double b=w.Getbalance();
//         // Console.WriteLine(b);
//         // BankAccount b=new BankAccount(455,67895);
//         // b.Deposit(678); 
//         // Employee e=new Employee("Jagriti",67899);
//         // e.DisplayDetails();
//     }
//     public static void Mulcal(int a,int b, out int q, out int r){
//         q=a/b;
//         r=a%b;
//     }
//     public static int sum(int a=10,params int[] num){
//         int total=0;
//         foreach(int i in num){
//             total+=i;
//         }
//         total+=a;
//         return total;
//     }
//     class BankAccount{
//         public int account_num;
//         private double balance;
//         public BankAccount(int acnt, double bal){
//             this.account_num=acnt;
//             this.balance=bal;
//         }
//         public void Deposit(double amount){
//             balance+=amount;
//             Console.WriteLine($"Updated Balance: {balance}");
//         }
//     }
//     class Employee{
//         public string name;
//         public double salary;

//         public Employee(string n, double s){
//             this.name=n;
//             this.salary=s;
//         }
//         public void DisplayDetails(){
//             Console.WriteLine($"Employee name:{name}, Employee salary:{salary}");

//         }
//     }
// }

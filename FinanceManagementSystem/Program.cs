using System;
using Debitdetails;
using Creditdetails;
class Fms{
    public static void Main(string[] args){

        Console.WriteLine("Main Menu Options:");
        int option=0;
        do{
            Console.WriteLine("1.Debit Operations");
            Console.WriteLine("2.Credit Operations");
            Console.WriteLine("3.Exit");
            Console.WriteLine("Choose Option: ");
            option=Convert.ToInt32(Console.ReadLine());
            switch(option){
                case 1:
                Debitclass(); 
                break;

                case 2:
                Creditclass();
                break;

                case 3:
                Console.WriteLine("Exiting Program..");
                break;
                default:
                Console.WriteLine("Invalid option");
                break;
            }
        }while(option!=3);

    }
    
    public static void Creditclass(){
        int option=0;
        do{
            Console.WriteLine("1. Net Salary Credit Calculation");
            Console.WriteLine("2. Fixed Deposit Maturity Calculation");
            Console.WriteLine("3. Credit Card Reward Points Evaluation");
            Console.WriteLine("4. Employee Bonus Eligibility Check");
            Console.WriteLine("5. Exit");
            option=Convert.ToInt32(Console.ReadLine());
            Credit cd=new Credit();
            switch(option){
                case 1:
                cd.Salary();
                break;

                case 2:
                cd.Fixd();
                break;

                case 3:
                cd.CreditReward();
                break;
                case 4:
                cd.EmplBonus();
                break;
                case 5:
                Console.WriteLine("Exiting Program..");
                break;
                default:
                Console.WriteLine("Invalid option");
                break;
            }
        }while(option!=5);


    }

    public static void Debitclass(){
        int option=0;
        do{
            Console.WriteLine("1. ATM Withdrawal Limit Validation");
            Console.WriteLine("2. EMI Burden Evaluation");
            Console.WriteLine("3. Transaction-Based Daily Spending Calculator");
            Console.WriteLine("4. Minimum Balance Compliance Check");
            Console.WriteLine("5. Exit");
            option=Convert.ToInt32(Console.ReadLine());
            Debit db=new Debit();
            switch(option){
                case 1:
                db.Atm();
                break;

                case 2:
                db.Emi();
                break;

                case 3:
                db.Trans();
                break;
                case 4:
                db.Bal();
                break;
                case 5:
                Console.WriteLine("Exiting Program..");
                break;
                default:
                Console.WriteLine("Invalid option");
                break;
            }
        }while(option!=5);

}
}
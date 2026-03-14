using System;
namespace Creditdetails{
    class Credit{
 public void Salary(){
            Console.WriteLine("Gross Salary: ");
            int salary=Convert.ToInt32(Console.ReadLine());
            int dedu=salary - (salary *10)/100;
            Console.WriteLine($"Net salary credited:{dedu}");
        }
        public void Fixd(){
            Console.WriteLine("Enter Principal: ");
            int p=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter rate of Interest: ");
            int r=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Time period: ");
            int t=Convert.ToInt32(Console.ReadLine());
            int si=(p+r+(t/12))/100;
            Console.WriteLine($"Fixed Deposit maturity amount: Rs.{p+si}");

        }
        public void CreditReward(){
            Console.WriteLine("Enter Total credit card spending: ");
            int spent=Convert.ToInt32(Console.ReadLine());
            int credpts=spent/100;
            Console.WriteLine($"Reward points earned: {credpts}");

        }
        public void EmplBonus(){
            Console.WriteLine("Enter Annual Salary: ");
            int ansal=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Years of Salary: ");
            int sal=Convert.ToInt32(Console.ReadLine());
            if(ansal>=500000 && sal>=3){
                Console.WriteLine("Employee is eligible for bonus.");
            }else {
                Console.WriteLine("Employee is not eligible for bonus.");
            }
        }
    }
}
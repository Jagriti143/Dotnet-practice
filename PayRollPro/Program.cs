using System;
namespace ns{
abstract class EmployeeRecord{
    public string ename{get;set;}
    public double[] w_hours=new double[4];
    public abstract double GetMonthlyPay();
}
class FullTimeEmployee:EmployeeRecord{
    public double h_rate{get;set;}
    public double mon_bon{get;set;}
    public override double GetMonthlyPay(){
        double sum=0;
        for(int i=0;i<4;i++){
            sum+=w_hours[i];
        }
        return (sum*h_rate)+mon_bon;
    }
}
class ContractEmployee:EmployeeRecord{
    public double h_rate{get;set;}
    public override double GetMonthlyPay(){
        double sum=0;
        for(int i=0;i<4;i++){
            sum+=w_hours[i];
        }
        return sum*h_rate;
    }
}
class MainClass{
    public static List<EmployeeRecord> record=new List<EmployeeRecord>();
    public static void RegisterEmployee(EmployeeRecord er){
        record.Add(er);
        Console.WriteLine("Employee registered successfully");
    }
    public static EmployeeRecord CreateObject(int choice){
        if(choice==1){
            FullTimeEmployee e=new FullTimeEmployee();
            Console.WriteLine("Enter Employee Name:");
            e.ename=Console.ReadLine();
            Console.WriteLine("Enter Hourly Rate:");
            e.h_rate=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Monthly bonus:");
            e.mon_bon=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter weekly hours (Week 1 to 4):");
            for(int i=0;i<4;i++){
                e.w_hours[i]=Convert.ToInt32(Console.ReadLine());
            }
            return e;

        }else if(choice==2){
            ContractEmployee e=new ContractEmployee();
            Console.WriteLine("Enter Employee Name:");
            e.ename=Console.ReadLine();
            Console.WriteLine("Enter Hourly Rate:");
            e.h_rate=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter weekly hours (Week 1 to 4):");
            for(int i=0;i<4;i++){
                e.w_hours[i]=Convert.ToInt32(Console.ReadLine());
            }
            return e;
        }
        return null;
    }
    public static Dictionary<string,int> GetOverTime(double threshold){
        Dictionary<string,int> dict=new Dictionary<string,int>();
        foreach(EmployeeRecord e in record){
            int count=0;
            for(int i=0;i<4;i++){
                if(e.w_hours[i]>=threshold){
                    count++;
                }
            }
            if(count!=0){
                dict.Add(e.ename,count);
            }
        }
        return dict;
    }
    public static double CalulatePay(){
        double total=0;
        foreach(EmployeeRecord e in record){
            total+=e.GetMonthlyPay();
        }
        return total/record.Count;
    }
    public static void Main(String[] args){
        int option=0;
        do{
            Console.WriteLine("1. Register Employee");
            Console.WriteLine("2. Show Overtime Summary");
            Console.WriteLine("3. Calculate Average Monthly Pay");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Enter Your Choice:");
            option=Convert.ToInt32(Console.ReadLine());
            switch(option){
                case 1:
                    Console.WriteLine("Select Employee Type (1-Full Time, 2-Contract):");
                    int choice=Convert.ToInt32(Console.ReadLine());
                    RegisterEmployee(CreateObject(choice));
                    break;
                case 2:
                    Dictionary<string,int> d=new Dictionary<string,int>();
                    Console.WriteLine("Enter hours threshold:");
                    int threshold=Convert.ToInt32(Console.ReadLine());
                    d=GetOverTime(threshold);
                    if(d.Count==0){
                        Console.WriteLine("No overtime recorded this month");
                    }else{
                        foreach(var v in d){
                            Console.WriteLine($"{v.Key}-{v.Value}");
                        }
                    }
                    break;
                case 3:
                    Console.WriteLine($"Overall average monthly pay: {CalulatePay()}");
                    break;
                case 4:
                    Console.WriteLine("Logging off — Payroll processed successfully!");
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
        }while(option!=4);
    }
}
}


// using System;
// using EMR;
// //using System.Collections;
// class MainClass{
//     public static void Main(string[] args){
//         FullTimeEmployee fe=new FullTimeEmployee();
//         //fe.GetMonthlyPay();
//         ContractEmployee ce=new ContractEmployee();
//        // ce.GetMonthlyPay();
//         int choice;
//         do{
//             Console.WriteLine("1. Register Employee");
//             Console.WriteLine("2. Show OverTime Summary");
//             Console.WriteLine("3. Calculate Average Monthly Salary");
//             Console.WriteLine("4.Exit");
//             Console.WriteLine("Enter a Choice: ");
//             choice=Convert.ToInt32(Console.ReadLine());
        
//         switch(choice){
//             case 1:
//                 Console.WriteLine("Select Employee Type(1- Full Time, 2- Contract)");
//                 int et=int.Parse(Console.ReadLine());
//                 Console.WriteLine("Enter Employee Name: ");
//                 string name=Console.ReadLine();
//                 Console.WriteLine("Enter Hourly Rate: ");
//                 double hr=double.Parse(Console.ReadLine());
//                 Console.WriteLine("Enter weekly hours (Week 1 to 4):");
//                 double[] weeklyhours=new double[4];
//                 for(int i=0;i<weeklyhours.Length;i++){
//                     weeklyhours[i]=int.Parse(Console.ReadLine());
//                 }
//                 if(et==1){
//                     Console.WriteLine("Enter monthly Bonus: ");
//                     double mb=double.Parse(Console.ReadLine());
//                     //FullTimeEmployee fe = new FullTimeEmployee();
//                         fe.GetMonthlyPay();
//                 }else if (et == 2)
//                     {
//                         //ContractEmployee ce = new ContractEmployee();
//                         ce.GetMonthlyPay();
//                     }
//                 Console.WriteLine("Employee Registered Successfully");
                
//                 break;
//             case 2:
//             break;
//             case 3:
//             double avg=fe.GetMonthlyPay();
//             Console.WriteLine($"Overall average monthly pay: {avg}");
//             break;
            
//             default:
//             Console.WriteLine("Invalid");
//             break;
            
//         }
//         }
//         while(choice !=4);
//         // public void RegisterEmployee(EmployeeRecord record){
        
//         // }
//         // public Dictionary<string,int> GetOverTimeWeekCounts=new Dictionary<string,int>();



//     }
// }

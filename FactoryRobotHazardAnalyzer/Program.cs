using System;
using Auditor;
class Mainclass{
    public static void Main(string[] args){
    Console.WriteLine("Enter Arm Precision (0.0 - 1.0):");
    double arm=Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter Worker Density (1 - 20):");
    int work=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter Machinery State (Worn/Faulty/Critical):");
    string machstat=Console.ReadLine();
    RobotHazardAuditor r=new RobotHazardAuditor();
    double x= r.CalculateHazardRisk(arm,work,machstat);
    Console.WriteLine($"Robot Hazard Risk Score: {x}");
    }
}

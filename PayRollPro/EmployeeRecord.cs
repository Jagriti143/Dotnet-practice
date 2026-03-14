// using System;
// using System.Collections.Generic;
// namespace EMR{
// abstract class EmployeeRecord{
//     public string employeename;
//     public double[] weeklyhours=new double[4];
//     public abstract double GetMonthlyPay();
// }
// class FullTimeEmployee:EmployeeRecord{
//     public double hourlyrate;
//     public double montlybonus;
//     public override double GetMonthlyPay(){
//         double sum=0;
//         for(int i=0;i<weeklyhours.Length;i++){
//             sum+=weeklyhours[i];
//         }
//         return (sum*hourlyrate)+montlybonus;
//     }
// }
// class ContractEmployee:EmployeeRecord{
//     public double hourlyrate;
//     public override double GetMonthlyPay(){
//         double sum=0;
//         for(int i=0;i<weeklyhours.Length;i++){
//            sum+=weeklyhours[i];
//         }
//         return (sum)*hourlyrate;
//     }

// public static List<EmployeeRecord> payrollBoard=new List<EmployeeRecord>();


// }
// }
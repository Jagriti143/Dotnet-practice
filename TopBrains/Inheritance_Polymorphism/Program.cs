using System;
using System.Collections.Generic;
using System.Collections;
public abstract class Employee
{
    
    public abstract double Salary();
    

}
public class HourlyEmployee : Employee
{
    public int hours{get;set;}
    public double rate{get;set;}
    public double pay=0.0;
    public override double Salary()
    {
        
        pay=rate*hours;
        return pay;
    }
}
public class SalariedEmployee : Employee
{
    public double monthsalary{get;set;}
    public double pay=0.0;
    public override double Salary()
    {
        pay=monthsalary;
        return pay;
    }
}
public class CommisionBaseSalary:Employee
{
    public double baseSalary{get;set;}
    public double Commision{get;set;}
    public double pay=0.0;
    public override double Salary()
    {
        pay=baseSalary+Commision;
        return pay;
    }
}

public class Program
{
    public static void Main(string[] args)
    {

        HourlyEmployee h=new HourlyEmployee();
        h.hours=int.Parse(Console.ReadLine());
        h.rate=double.Parse(Console.ReadLine());
        double hs=h.Salary();
        Console.WriteLine(hs:F2);

        SalariedEmployee s=new SalariedEmployee();
        s.monthsalary=double.Parse(Console.ReadLine());
        double ms=s.Salary();
        Console.WriteLine(ms:F2);

        CommisionBaseSalary c=new CommisionBaseSalary();
        c.baseSalary=double.Parse(Console.ReadLine());
        c.Commision=double.Parse(Console.ReadLine());
        double cs=c.Salary();
        double total=hs+ms+cs;
        Console.WriteLine(total:F2);
        
        
    }
}

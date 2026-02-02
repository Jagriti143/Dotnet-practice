using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public string Name{get;set;}
    public int Age{get;set;}
    public double Marks{get;set;}
    public Student(string n,int a,double m)
    {
        this.Name=n;
        this.Age=a;
        this.Marks=m;
    }
    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}, Marks: {Marks}";
    }
}
public class StdCompare : IComparer<Student>
{
    public int Compare(Student a,Student b)
    {
        int m=b.Marks.CompareTo(a.Marks);
        if (m != 0)
        {
            return m;
        }
        return a.Age.CompareTo(b.Age);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Student s1=new Student("Jagriti",21,80);
        Student s2=new Student("Karan",21,50);
        Student s3=new Student("Yuvraj",23,89);
        
        List<Student> std=new List<Student>();
        std.Add(s1);
        std.Add(s2);
        std.Add(s3);
        //std=std.OrderByDescending(s=>s.Marks).ThenBy(s=>s.Age).ToList();
        std.Sort(new StdCompare());
        foreach(Student i in std)
        {
           Console.WriteLine(i);
        }
    }
}

using System;
using LibraryData;
class Mainclass{
    public static void Main(string[] args){
        // Library lb=new Library();
        // lb[101]="Maths";
        // lb[102]="English";
        // lb[103]="Science";
        // Console.WriteLine(lb[101]);
        // Console.WriteLine(lb[102]);
        // Console.WriteLine(lb[103]);
        // Console.WriteLine(lb["Maths"]);
        Student p=new Student("Jagriti",34);
        
    }

        class Person
{
    public string Name;

    public Person(string name)
    {
        Name = name;
    }
}

class Student : Person
{
    public int RollNo;

    public Student(string name, int roll) : base(name)
    {
        RollNo = roll;
    }
}


    
}

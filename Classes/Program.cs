using System;
class Mainclass{
    public static void Main(string[] args){
        // Student s=new Student(45,"Jagriti","fashion");
        // Student y=new Student(55,"karan");
        // s.Display();
        // y.Display();


        // BankAccount b=new BankAccount();
        // b.setbalance(5678);
        // double bal=b.getbalance();
        // Console.WriteLine($"Balance: {bal}");

        // User u=new User("admin","admin");
        // bool x=u.AuthUser();
        // if(x==true){
        // Console.WriteLine("Authorized user");
        // }else{
        //     Console.WriteLine("Unauthorized user");
        // }


        // Dog d=new Dog();
        // d.bark();
        // d.eat();
        Student s=new Student(67,"Jagriti");
        s.Display();
        Lpustudent l=new Lpustudent("lpu",67,"Karan");
        l.Display();


    }
}

class Person{
    public string name;
    public Person(string n){
        this.name=n;
    }
}
class Student:Person{
    public int studentId;
    public Student(int s,string n):base(n){
        this.studentId=s;
    }
    public void Display(){
        Console.WriteLine($"student name: {name} , student id: {studentId}");
    }
}
class Lpustudent:Student{
    public string clgname;
    public Lpustudent(string c,int s,string n):base(s,n){
        this.clgname=c;
    }
    public void Display(){
        Console.WriteLine($"student name: {name} , student id: {studentId}, clg name:{clgname}");
    }

}


// class Animal{
//     public void eat(){
//         Console.WriteLine("parent class");
//     }
//     public Animal(){
//         Console.WriteLine("parent constructor");
//     }
//     ~Animal(){
//         Console.WriteLine("parent destructor");
//     }
// }
// class Dog:Animal{
//     public void bark(){
//         Console.WriteLine("child class");
//     }
//     public Dog(){
//         Console.WriteLine("child constructor");
//     }
//     ~Dog(){
//         Console.WriteLine("child destructor");
//     }
// }



// class User{
//     public string username;
//     private string pswd;
//     public User(string u, string p){
//         this.username=u;
//         this.pswd=p;
//     }
//     public bool AuthUser(){
//         if(username=="admin" && pswd=="admin"){
//             return true;
//         }
//         return false;
//     }

// }


// class BankAccount{
//     public double balance;
//     public void setbalance(double b){
//         balance=b;
//     }
//     public double getbalance(){
//         return balance;
//     }

// }

//Constructor
// class Student{
//     public int rollno;
//     public string name;
//     public string department="cse";
//     public Student(int r,string s, string d){
//         rollno=r;
//         name=s;
//         department=d;

//     }
//     public Student(int r,string s){
//         rollno=r;
//         name=s;
//     }
//     public void Display(){
//         Console.WriteLine($"Roll no: {rollno}");
//         Console.WriteLine($"Name: {name}");
//         Console.WriteLine($"Department: {department}");
//     }
// }
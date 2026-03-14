using System;
using HelloWorldApp;
using Calculator;

class HelloWorld
{
    public static void Main(string[] args)
    {
    //    Console.WriteLine("HelloWorld"); 
    //    Console.ReadLine();
    // Employee employee =new Employee();
    // employee.AcceptDetails();
    // employee.DisplayDetails();
    // Cal cal=new Cal();
    // cal.Add();
    // cal.Sub();
    // cal.Mul();
    // cal.Div();
    // cal.Mod();

    //2. Write a  c# program to read a number user and display it
    // Console.WriteLine("Enter a number: ");
    // int num=Convert.ToInt32(Console.ReadLine());
    // Console.WriteLine($"Number is : {num}");


    //3. Write c# program to read a floating point number from user
    // Console.WriteLine("Enter a Number: ");
    // float num=Convert.ToSingle(Console.ReadLine());
    // Console.WriteLine($"Number is : {num}");

    //4. Write a c# program to read a string  from user
    // Console.WriteLine("Enter a String: ");
    // string s=Console.ReadLine();
    // Console.WriteLine($"String is: {s}");

    //5. perform all the arithmetic operations


    //6. Write c# program to find the area of circle
    // Console.WriteLine("Enter a radius: ");
    // int radius=Convert.ToInt32(Console.ReadLine());
    // float pi= 3.14f;
    // float area=radius* radius *pi;
    // Console.WriteLine($"Area of Circle: {area}");

    //7.program to find weather the number is even or odd
    // Console.WriteLine("Enter a number: ");
    // int num=Convert.ToInt32(Console.ReadLine());
    // if(num%2==0){
    //     Console.WriteLine("Number is even");
    // }else{
    //     Console.WriteLine("Number is Odd");
    // }


    //8.program to find the greatest of 2 numbers
    // Console.WriteLine("Enter the num1: ");
    // int num1=Convert.ToInt32(Console.ReadLine());
    // Console.WriteLine("Enter the num2: ");
    // int num2=Convert.ToInt32(Console.ReadLine());
    // if(num1>num2){
    //     Console.WriteLine($"{num1} is the greatest number");
    // }else{
    //     Console.WriteLine($"num1{num2} is the greatest number");
    // }


    //9.program to find weather a given number is positive, negative or zero
    // Console.WriteLine("Enter a number: ");
    // int num=Convert.ToInt32(Console.ReadLine());
    // if(num>0){
    //     Console.WriteLine($"{num} is Postive");
    // }else if(num==0){
    //     Console.WriteLine($"{num} is zero");
    // }else{
    //     Console.WriteLine($"{num} is negative");
    // }


    //10.program to find the greatest of three numbers using nested if

    // Console.WriteLine("Enter num1: ");
    // int num1=Convert.ToInt32(Console.ReadLine());
    // Console.WriteLine("Enter num2: ");
    // int num2=Convert.ToInt32(Console.ReadLine());
    // Console.WriteLine("Enter num3: ");
    // int num3=Convert.ToInt32(Console.ReadLine());
    // if(num1>num2 && num1>num3){ // without nested if
    //     Console.WriteLine($"{num1} is the Greatest number");
    // }else if(num2>num1 &&  num2 > num3){
    //     Console.WriteLine($"{num2} is the Greatest  number");
    // }else{
    //     Console.WriteLine($"{num3} is the Greatest number");
    // }




    // if(num1>num2){
    //     if(num1>num3){
    //         Console.WriteLine($"{num1} is the Greatest number");
    //     }else{
    //         Console.WriteLine($"{num3} is the Greatest number");
    //     }
    // }else{
    //     Console.WriteLine($"{num2} is the Greatest number");
    // }


// case study 1:
    // Console.WriteLine("Enter a Character: ");
    // char c=Convert.ToChar(Console.ReadLine());
    // switch(c){
    //     case 'a':
    //     Console.WriteLine($"The character '{c}' is a vowel");
    //     break;
    //     case 'e':
    //     Console.WriteLine($"The character '{c}' is a vowel");
    //     break;
    //     case 'i':
    //     Console.WriteLine($"The character '{c}' is a vowel");
    //     break;
    //     case 'o':
    //     Console.WriteLine($"The character '{c}' is a vowel");
    //     break;
    //     case 'u':
    //     Console.WriteLine($"The character '{c}' is a vowel");
    //     break;
    //     case 'A':
    //     Console.WriteLine($"The character '{c}' is a vowel");
    //     break;
    //     case 'E':
    //     Console.WriteLine($"The character '{c}' is a vowel");
    //     break;
    //     case 'I':
    //     Console.WriteLine($"The character '{c}' is a vowel");
    //     break;
    //     case 'O':
    //     Console.WriteLine($"The character '{c}' is a vowel");
    //     break;
    //     case 'U':
    //     Console.WriteLine($"The character '{c}' is a vowel");
    //     break;
    //     default:
    //     Console.WriteLine($"The character '{c}' is not a vowel");
    //     break;
    // }

    // Case study 2:
    //Console.WriteLine("Enter a String: ");
    // string s=Console.ReadLine();
    // Console.WriteLine($"Original string length: {s.Length}");
    // string up=s.ToUpper();
    // Console.WriteLine($"Uppercase string: {up}");

//case study 3:
    // int num1=Convert.ToInt32(Console.ReadLine());
    // int num2=Convert.ToInt32(Console.ReadLine());
    // Console.WriteLine($"Before Swap: a={num1}, b={num2}");
    //  Console.WriteLine($"After Swap: a={num1+num2-num1}, b={num1+num2-num2}");

    // int x=0;
    // while(x<5){
    //     Console.WriteLine(x);
    //     x++;
    // }
    
    // int x=5;
    // while(x>0){
    //     Console.WriteLine(x);
    //     x--;
    // }

    // int cnt=0;
    // do{
    //     Console.WriteLine(cnt);
    //     cnt++;
    // }while(cnt<=5);

    // int a=5;
    // for(int i=1;i<=10;i++){
    //     Console.WriteLine($"{a} X {i} = {i*a}");
    // }

    //int t=20;
    // for(int j=20;j<=30;j++){
    //     Console.WriteLine($"Table of {j}");
    // for(int i=1;i<=10;i++){
    //     Console.WriteLine($"{j} X {i} = {i*j}");
    // }
    // }

    // Console.WriteLine("GAME BEGINS");
    // for(int i=1;i<=10;i++){
    //     if(i==4){
    //         Console.WriteLine($"Enemy 4 is invisible. Skipping Enemy 4");
    //         continue;
    //     }
    //     Console.WriteLine($"Player Killed Enemy {i}");
    // }
    // Console.WriteLine("GAME ENDS");
     
        int choose=0;
        do{
         //Console.WriteLine("choose option: ");   
        //choose=Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Enter amount: ");
        // int tax=Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Enter age: ");
        // int age=Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Enter transaction: ");
        // int trans=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Check Loan Eligibility");
        Console.WriteLine("Calculate Tax");
        Console.WriteLine("Enter Transactions");
        Console.WriteLine("Exit");
        Console.WriteLine("choose option: ");  
        choose=Convert.ToInt32(Console.ReadLine());
        
        switch(choose){
    

        case 1:
        Console.WriteLine("Enter age: ");
        int age=Convert.ToInt32(Console.ReadLine());
        LoanEligibilityCheck(age);
        Console.WriteLine("Enter transaction: ");
        int trans=Convert.ToInt32(Console.ReadLine());
        TransactionRules(trans);
        break;
        case 2:
        Console.WriteLine("Enter amount: ");
        int tax=Convert.ToInt32(Console.ReadLine());
        IncomeTaxCalculation(tax);
        break;
        case 4:
            Console.WriteLine("Exiting program...");
            break;
        default:
        Console.WriteLine("Invalid choice");
        break;
    }
        }while(choose !=4);
    }

    public static void LoanEligibilityCheck(int age){
        if(age>=21){
            Console.WriteLine("Eligible for loan");
        }

    }
    public static  void IncomeTaxCalculation(int tax){
        if(tax<=250000){
            Console.WriteLine($"Income Tax is 0% ");
        }else if(tax>=250001 && tax <=500000){
            Console.WriteLine($"Income Tax is {tax * 0.05}");
        }else if(tax >=500001 && tax <=1000000){
            Console.WriteLine($"Income Tax is { tax * 0.2}");
        }else{
            Console.WriteLine($"Income Tax is { tax * 0.3}");
        }

    }
    public static void TransactionRules(int trans){
        //trans=Convert.ToInt32(Console.ReadLine());
        for(int i=0;i<5;i++){
            if(i<0){
                Console.WriteLine("Invalid Transcation");
                continue;
            }
            Console.WriteLine("Transaction is valid");
            
        }
    }


}

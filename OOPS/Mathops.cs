using System;
namespace Mathops{
    class Maths{
        public static int Add(int n1,int n2){
            return n1+n2;
        }
        public double Add(double n1, double n2){
            return n1+n2;
        }

        public void Person(string name,int age,string city,char gender='M'){
            Console.WriteLine($"{name},{age},{gender},{city}");
        }
        
        
    }
}
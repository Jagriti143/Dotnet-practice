using System;
namespace securityModule{
    sealed class Auth{
        public Auth(){
        Console.WriteLine("User authenticated successfully");
        }
    }
    public abstract class InsurancePolicy{
        public int policynum{
            get;
            init;
        }
        protected int preminum=4500;
        public int preminumProperty{
            get{
                return preminum;
            }
            set{
                if(value<=0){
                   throw new ArgumentException("premium must be greater than zero");
                }
                preminum=value;
                
            }
        }
        public string holdername{
            get;
            set;
        }
        public virtual int calculate(){
            return preminum;
        }
        public void display(){
            Console.WriteLine($"Policy Number: {policynum}");
            Console.WriteLine($"PolicyHolder name: {holdername}");
            Console.WriteLine($"Life Premium: {preminum}");
            
        }
    }
    

}
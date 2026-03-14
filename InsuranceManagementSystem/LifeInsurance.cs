using System;
using securityModule;
namespace LifeInsData{
    class LifeInsurance :InsurancePolicy{
        public override int calculate(){
            Console.WriteLine($"Life Premium after adding charges: {preminum+=100}");
        
        return preminum;
        }
    }
   
}
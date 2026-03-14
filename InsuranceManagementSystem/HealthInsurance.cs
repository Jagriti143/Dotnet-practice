using System;
using securityModule;
namespace HealthData{
    class HealthInsurance:InsurancePolicy{
        public sealed override int calculate(){
            Console.WriteLine($"Life Premium overidden: {preminum+=2900}");
            return preminum;
        }
    }
}
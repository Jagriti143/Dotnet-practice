using System;
using securityModule;
using LifeInsData;
using HealthData;
using PolicyData;
class Mainclass{
    public static void Main(string[] args){
        Auth a=new Auth();
        LifeInsurance l=new LifeInsurance
        {
            policynum = 101,
            holdername = "Jagriti"
        };
        l.calculate();
        l.display();
        
        HealthInsurance h=new HealthInsurance{
            policynum = 102,
            holdername = "Amit"
        };
        h.calculate();

    }
}
using System;
namespace Auditor{
    class RobotSafetyException : Exception{
        public RobotSafetyException(string msg):base(msg){}
    }
    class RobotHazardAuditor{
        public double hazard_risk;
        public double CalculateHazardRisk(double armPrecision, int workerDensity, string machineryState){
            if(armPrecision>1.0 && armPrecision <0.0){
                throw new RobotSafetyException("Error:  Arm precision must be 0.0-1.0");
            }
            if(workerDensity>20 && workerDensity<1){
                throw new RobotSafetyException("Error: Worker density must be 1-20");
            }
            if(machineryState=="Worn" || machineryState=="Faulty" || machineryState=="Critical"){
                Console.WriteLine($"Machinery State: {machineryState}");
            }else{
                throw new RobotSafetyException("Error: Unsupported machinery state");
            }
               double machineRiskFactor=0.0;
                if(machineryState=="Worn"){
                machineRiskFactor=1.3;
                }else if(machineryState=="Faulty"){
                machineRiskFactor=2.0;
                }else{
                machineRiskFactor=3.0;
                }
                hazard_risk = ((1.0 - armPrecision) * 15.0) + (workerDensity * machineRiskFactor);
            return hazard_risk;
        }
    }
}
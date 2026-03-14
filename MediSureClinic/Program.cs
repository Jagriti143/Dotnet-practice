using System;
using PB;
class MainClass{
    public static void Main(string[] args){
        PatientBill p=new PatientBill();
        int option=0;
        do{
            Console.WriteLine("----------MediSure Clinic Billing----------");
            Console.WriteLine("1. Create New Bill (Enter Patient Details)");
            Console.WriteLine("2. View Last Bill");
            Console.WriteLine("3. Clear Last Bill");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Enter your option: ");
            option=int.Parse(Console.ReadLine());
            switch(option){
                case 1:
                Console.WriteLine("Enter Bill Id: ");
                p.billid=Console.ReadLine();
                Console.WriteLine("Enter Patient Name: ");
                p.patientName=Console.ReadLine();
                Console.WriteLine("Is the patient insured? (Y/N): ");
                p.isInsurance=Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Enter Consultation Fee: ");
                p.consfee=Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Enter Lab Charges: ");
                p.labCharges=Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Enter Medicine Charges: ");
                p.medCharges=Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Bill created successfully.");
                p.grossAmt=p.consfee+p.labCharges+p.medCharges;
                Console.WriteLine($"Gross Amount: {p.grossAmt}");
                p.disAmt=0m;
                if(p.isInsurance=='Y'){
                    p.disAmt=p.grossAmt*0.10m;
                    Console.WriteLine($"Discount Amount: {p.disAmt}");
                }else{
                Console.WriteLine($"Discount Amount: {p.disAmt}");
                }
                p.finalPayable=p.grossAmt-p.disAmt;
                Console.WriteLine($"Final Payable: {p.finalPayable}");
                break;
            case 2:
            if(p.grossAmt>0){

                Console.WriteLine($"Bill Id: {p.billid}");
                Console.WriteLine($"Patient Name: {p.patientName}");
                Console.WriteLine($"insured: {p.isInsurance}"); 
                Console.WriteLine($"Consultation Fee: {p.consfee}");
                Console.WriteLine($"Lab Charges: {p.labCharges}");
                Console.WriteLine($"Medicine Charges: {p.medCharges}");
                Console.WriteLine($"Gross Amount: {p.grossAmt}");
                Console.WriteLine($"Discount Amount: {p.disAmt}");
                Console.WriteLine($"Final Payable: {p.finalPayable}");
            }else{
                Console.WriteLine("No bill available. Please create a new bill first.");
            }
                break;
            case 3:
            p.consfee=0m;
            p.medCharges=0m;
            p.labCharges=0;
            p.grossAmt=0;
            p.disAmt=0;
            p.finalPayable=0;
            Console.WriteLine("Last Bill Cleared");
            break;
            case 4:
            Console.WriteLine("Thank you. Application closed normally.");
            break;
            default:
            Console.WriteLine("Invalid Input");
            break;
            }
        }while(option !=4);

    }
}

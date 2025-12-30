using System;
namespace ST{
    class SaleTransaction{
       public string invoiceNo;
       public string custumorename;
       public string itemName;
       public int quant;
       public decimal purchaseAmount;
       public decimal sellingamt;
       public string profitorlossStatus;
       public decimal profitorlossamt=0m;
       public decimal marginpercent;

        public string status(){
            if(sellingamt>purchaseAmount){
                profitorlossStatus="PROFIT";
              profitorlossamt=sellingamt-purchaseAmount;
            }else if(sellingamt<purchaseAmount){
                profitorlossStatus="LOSS";
                profitorlossamt=profitorlossamt-sellingamt;
            }else{
                profitorlossStatus="BREAK-EVEN";
                profitorlossamt=0;
            }
            marginpercent=(profitorlossamt/purchaseAmount)*100;
            return profitorlossStatus;
        }
       public void Trans(){
            Console.WriteLine("Enter Invoice No: ");
            invoiceNo=Console.ReadLine();
            Console.WriteLine("Enter Customer Name: ");
            custumorename=Console.ReadLine();
            Console.WriteLine("Enter Item Name: ");
            itemName=Console.ReadLine();
            Console.WriteLine("Enter Quantity: ");
            quant=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Purchase Amount (total): ");
            purchaseAmount=decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter Selling Amount (total):");
            sellingamt=decimal.Parse(Console.ReadLine());
            Console.WriteLine("Transaction saved successfully.");
            string s=status();
            Console.WriteLine($"Status: {s}");
           if(s=="PROFIT"){
            Console.WriteLine($"Profit/Loss Amount:{profitorlossamt}");
            }else if(s=="LOSS"){
                Console.WriteLine($"Profit/Loss Amount:{profitorlossamt}");
            }else{
                Console.WriteLine($"Profit/Loss Amount:{profitorlossamt}");
            }

            Console.WriteLine($"Profit Margin (%): {marginpercent:F2}");
       }
       public void LastTrans(){
        if(quant==0 && purchaseAmount==0 && sellingamt==0){
            Console.WriteLine("No transaction available. Please create a new transaction first.");
        }else{
        Console.WriteLine($"Enter Invoice No: {invoiceNo}");
            Console.WriteLine($"Enter Customer Name:{custumorename} ");
            Console.WriteLine($"Enter Item Name:{itemName} ");
            Console.WriteLine($"Enter Quantity:{quant} ");
            Console.WriteLine($"Enter Purchase Amount (total): {purchaseAmount}");
            Console.WriteLine($"Enter Selling Amount (total):{sellingamt}");
            string s=status();
            Console.WriteLine($"Status: {s}");
            Console.WriteLine($"Profit/Loss Amount:{profitorlossamt}");
            Console.WriteLine($"Profit Margin (%): {marginpercent:F2}");
       } 
       }

    }
}
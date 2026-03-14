using System;
using Choco;
class Program{
    public static Chocolate CalculateDiscountedPrice(Chocolate chocolate){
            chocolate.TotalPrice=chocolate.Quant * chocolate.PriceperUnit;
            double dis=0;
            if(chocolate.Flavour=="Dark"){
                dis=0.18;
            }else if(chocolate.Flavour=="Milk"){
                dis=0.12;
            }else{
                dis=0.06;
            }
            chocolate.DiscountedPrice=chocolate.TotalPrice -(chocolate.TotalPrice * dis );
            return chocolate;
        }
    public static void Main(string[] args){
        Chocolate c=new Chocolate();
        Console.WriteLine("Enter the flavour");
        c.Flavour=Console.ReadLine();
        Console.WriteLine("Enter the quantity");
        c.Quant=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the price per unit");
        c.PriceperUnit=int.Parse(Console.ReadLine());
        if(c.ValidateChocolateFlavour()){
            Console.WriteLine("Flavour: "+c.Flavour);
            Console.WriteLine("Quantity: "+c.Quant);
            Console.WriteLine("Price Per unit: "+c.PriceperUnit);
            c=CalculateDiscountedPrice(c);
            Console.WriteLine("Total Price: "+ c.TotalPrice);
            Console.WriteLine("Discounted Price: "+c.DiscountedPrice);

        }else{
            Console.WriteLine("Invalid flavour");
        }

    }
}
using System;
struct PriceSnapshot{
    public string stockSymbol;
    public double stockPrice;

}
abstract class Trade{
    public int tradeId{get; set;}
    public string stockSymbol{get; set;}
    public int quantity{get; set;}
    public abstract double TradeValue ();
    public override string ToString(){
        return $"{tradeId}, {stockSymbol}, {quantity}";
    }
}
class EquityTrade:Trade{
    public double ? marketPrice{get; set;}
    public override double TradeValue(){

        double price=marketPrice??0.0;
        return price*quantity;
    }
    public void TradeProcessing(){
            Console.WriteLine("Equity Trade");

    }
}
class TradeRepository<T> where T:Trade{
    private List<T> l1=new List<T>();
    public T obj;
    public void add(T x){
        l1.Add(x);
    }
    public int TradeCount(){
        return l1.Count();
    }

}
static class TradeAnalytics{
   public static int total;
   public static void display(){
    Console.WriteLine($"Trade Analytics:{total}");
   }
}
static class Extensions{
    public static double price=10000;
    public static double Brokerage(this double amt){
        price+=amt;
        return price;
    }
    public static double Tax(this double tax){
            return (price*tax)/100;
    }
}
class Mainclass{
    public static void Main(string[] args){
        PriceSnapshot p=new PriceSnapshot{
            stockSymbol="APPL",
            stockPrice=90
        };
        EquityTrade t=new EquityTrade();
        t.tradeId=98;
        t.stockSymbol="TCS";
        t.quantity=45;
        t.marketPrice=345;
        Console.WriteLine(t);
        Console.WriteLine(t.TradeValue());
        TradeRepository<Trade> tr=new TradeRepository<Trade>();
        tr.add(new EquityTrade{tradeId=1,stockSymbol="Jagriti",quantity=100});
        tr.add(new EquityTrade{tradeId=2,stockSymbol="Karan",quantity=2000});
        Console.WriteLine(tr.TradeCount());
        TradeAnalytics.total=Convert.ToInt32(Console.ReadLine());
        TradeAnalytics.display();
        double amt=2900;
        double tax=20;
        Console.WriteLine(amt.Brokerage());
        Console.WriteLine(tax.Tax());
        Trade trade = new EquityTrade();

        if (trade is EquityTrade et)
        {
            et.TradeProcessing();
        }
        int tradecnt=6000;
        object boxedamt=tradecnt;
        int unboxedamt=(int)boxedamt;
        Console.WriteLine($"Boxed Amount: {boxedamt}");
        Console.WriteLine($"UnBoxed Amount: {unboxedamt}");
        
    }
}

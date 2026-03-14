using System;
using EcommerceAssessment;
using System.Collections.Generic;
class MainClass{
    public static void Main(string[] args){
        Repository<Order> repository=new Repository<Order>();
        repository.Add(new Order{order_id=1,customer_name="Alice",amount=5000});
        repository.Add(new Order{order_id=2,customer_name="Bob",amount=1900});
        repository.Add(new Order{order_id=3,customer_name="Charlie",amount=9000});

        Func<double,double> taxcalculated=amount=>amount*0.18;
        Func<double,double> discouncalculated=amount=>amount*0.15;
        Predicate<Order> ValidAmount=order=>order.amount>2500;
        OrderCallback callback=message=>{
            Console.WriteLine($"[callback] {message}");
        };
        Action<string> Logger=msg=>{
            Console.WriteLine($"Logger: {msg}");
        };
        Action<string> Notifier=msg=>{
            Console.WriteLine($"Notifier: {msg}");
        };
        Action<string> NotficationHandler=null;
        NotficationHandler+=Logger;
        NotficationHandler+=Notifier;

        OrderProcessor processor=new OrderProcessor();
        processor.OrderProcessed+=NotficationHandler;

        Console.WriteLine("---Processing Order--");
        foreach(var ord in repository.GetAll()){
            processor.ProcessOrder(ord,taxcalculated,discouncalculated,ValidAmount,callback);
        }
        Comparison<Order> sortByAmount=(o1,o2)=>o2.amount.CompareTo(o1.amount);
        var orders=repository.GetAll();
        orders.Sort(sortByAmount);
        Console.WriteLine("Sorted Orders: ");
        foreach(var order in orders){
            Console.WriteLine(order.ToString());
        }
    }
}

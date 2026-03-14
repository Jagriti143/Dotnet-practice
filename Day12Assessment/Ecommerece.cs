using System;
using System.Collections.Generic;
namespace EcommerceAssessment{
    class Repository<T>{
        private List<T> items=new List<T>();
        public void Add(T item){
            items.Add(item);
        }
        public List<T> GetAll(){
            return items;
        }
    }
    class Order{
        public int order_id{get;set;}
        public string customer_name{get;set;}
        public double amount{get;set;}
        public override string ToString(){
            return "Order Id: "+order_id+" Customer Name: "+customer_name+" Amount: "+amount;
        }
    }
    public delegate void OrderCallback(string message);
    class OrderProcessor{
        public event Action<string> OrderProcessed;
        public void ProcessOrder(Order order,
        Func<double,double> taxCalculator,
        Func<double,double> discountCalculator,
        Predicate<Order> validator,
        OrderCallback callback){
            bool isvalid=validator(order);
            if(!isvalid){
                callback?.Invoke("Invalid Order");
                return;
            }
            double tax=taxCalculator(order.amount);
            double discount=discountCalculator(order.amount);
            order.amount=order.amount+tax-discount;
            OrderProcessed?.Invoke($"Order {order.order_id} Processed Successfully");
        }
    }
}
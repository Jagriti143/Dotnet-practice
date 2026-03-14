using System;
namespace library{
    namespace Item{
    abstract class LibraryItem{
        public string title;
        public string author;
        public int itemid;
        public LibraryItem(string t,string a,int i){
            this.title=t;
            this.author=a;
            this.itemid=i;
        }
        public abstract void Display();
        public abstract double calculate(int day);
    }
    class Book:LibraryItem,IReservable,INotifiable{
        public Book(string t,string a,int i):base(t,a,i){}
        public override void Display(){
            Console.WriteLine($"Title of Book: {title}");
            Console.WriteLine($"Author of Book: {author}");
            Console.WriteLine($"Item Id: {itemid}");
            
        }
        
        public override double calculate(int day){
            double latefees=1*day;
            return latefees;
        }
        public void reserve(){
            Console.WriteLine("Reservation success");
        }
        public void msg(string msg){
            Console.WriteLine($"Notification message sent:{msg}");
        }
    }
    class Magazine:LibraryItem{
        public Magazine(string t,string a,int i):base(t,a,i){}
        public override void Display(){
            Console.WriteLine($"Title of Magazine: {title}");
            Console.WriteLine($"Author of Magazine: {author}");
            Console.WriteLine($"Item Id of Magazine: {itemid}");
            

        }
        public override double calculate(int day){
            double latefees=0.5*day;
            return latefees;
        }

    }
    }
    namespace Users{
        class Member{
        public int id;
        public string name;
        public Member(int i, string n){
            this.id=i;
            this.name=n;
            Console.WriteLine($"id: {id}, name: {name}");
        }
        }
    }
}
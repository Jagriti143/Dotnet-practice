using System;
using Items=library.Item;
using users=library.Users;

class Mainclass{
    public static void Main(string[] args){
        users.Member mem=new users.Member(12,"Jasmine");

        Items.Book b=new Items.Book("gjkm","jfgb",56);
        double y=b.calculate(7);
        b.Display();
        Console.WriteLine($"lateFees:{y}");
        Items.Magazine m=new Items.Magazine("ukn","efg",867);
        double x=m.calculate(5);
        m.Display();
        Console.WriteLine($"lateFees:{x}");
        b.reserve();
        b.msg("hello");
        List<Items.LibraryItem> l=new List<Items.LibraryItem>();
        Items.LibraryItem i1=new Items.Book("ghj","ijb",78);
        Items.LibraryItem i2=new Items.Magazine("jagriti","igg",87);
        l.Add(i1);
        l.Add(i2);
        for(int i=0;i<l.Count;i++){
            DisplayItemDetails(i,l);
        }
        
    }
    public static void DisplayItemDetails(int i, List<Items.LibraryItem> l){
            Console.WriteLine($"Item id is : {l[i].itemid}");
        }
}

interface IReservable{
    void reserve();
}
interface INotifiable{
    void msg(string msg);

}

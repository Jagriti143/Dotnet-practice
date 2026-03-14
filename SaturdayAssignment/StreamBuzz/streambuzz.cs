using System;
using System.Collections;
using System.Collections.Generic;
class CreatorStats{
    public string creatorName;
    public double[] weeklylikes=new double[4];
}
class Program{
    public static List<CreatorStats> EngagementBoard=new List<CreatorStats>();
    public static void RegisterCreator(CreatorStats record){
        EngagementBoard.Add(record);
    }
    public static CreatorStats objectCreate(){
        CreatorStats c=new CreatorStats();
        Console.WriteLine("Enter creator name: ");
        c.creatorName=Console.ReadLine();
        Console.WriteLine("Enter weekly likes (Week 1 to 4):");
        for(int i=0;i<4;i++){
            c.weeklylikes[i]=Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Creator registered successfully");
        return c;
    }
    public static Dictionary<string, int> GetTopPostCounts(double likeThreshold){
        Dictionary<string,int> dict=new Dictionary<string,int>();
        foreach(CreatorStats c in EngagementBoard){
            int cnt=0;
            for(int i=0;i<4;i++){
                if(c.weeklylikes[i]>=likeThreshold){
                    cnt++;
                }
            }
            if(cnt!=0){
                dict.Add(c.creatorName,cnt);
            }
            
        }
        return dict;
    }
    public static double CalculateAverageLikes(){
        double sum=0;
        foreach(CreatorStats c in EngagementBoard){
            for(int i=0;i<4;i++){
            sum+=c.weeklylikes[i];
            }
        }
        double ans=sum/(4*EngagementBoard.Count);
        return ans;
    }
    public static void Main(string[] args){
        int option=0;

        do{
            Console.WriteLine("1. Register Creator");
            Console.WriteLine("2. Show Top Posts");
            Console.WriteLine("3. Calculate Average Likes");
            Console.WriteLine("4. Exit");
            option=int.Parse(Console.ReadLine());
            switch(option){
                case 1:
                RegisterCreator(objectCreate());
                break;
                case 2:
                Console.WriteLine("Enter like threshold: ");
                int likeThreshold=int.Parse(Console.ReadLine());
                Dictionary<string,int> dict=GetTopPostCounts(likeThreshold);
                    if(dict.Count==0){
                        Console.WriteLine("No top-performing posts this week");
                    }else{
                        foreach(var i in dict){
                        Console.WriteLine($"{i.Key} - {i.Value}");
                        }
                    }
                break;
                case 3:
                Console.WriteLine($"Overall average weekly likes:{CalculateAverageLikes()}");
                break;
                case 4:
                Console.WriteLine("Logging off - Keep Creating with StreamBuzz!");
                break;
                default:
                Console.WriteLine("Invalid choice");
                break;
            }

        }while(option!=4);

    }
}
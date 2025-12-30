using System;
class Mainclass{
    public static string CleanseAndInvert(string x){
        x=x.ToLower();
        if(x.Length<6){
            return "";
        }
        for(int i=0;i<x.Length;i++){
            if(!char.IsLetter(x[i])){
                return "";
            }
        }
        string ans="";
        for(int i=0;i<x.Length;i++){
            // int a=(int)x[i];
            if((int)x[i]%2==0){
               x=x.Remove(i,1);
                i--;
            }else{
                ans+=x[i];
            }
        }
        ans=new string(ans.Reverse().ToArray());
        string res="";
        for(int i=0;i<ans.Length;i++){
            if(i%2==0){
            res+=char.ToUpper(ans[i]);
            }else{
                res+=ans[i];
            }

        }

    return res;
      
    }
    public static void Main(string[] args){
        Console.WriteLine("Enter the word: ");
        string word=Console.ReadLine();
        string ans=CleanseAndInvert(word);
        if(ans.Length==0){
            Console.WriteLine("Invalid input");
        }else{
            Console.WriteLine($"The Generated Key is: {ans}");
        }

    }
}
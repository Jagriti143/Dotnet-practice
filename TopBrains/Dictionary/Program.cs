using System;
using System.Collections.Generic;
using System.Collections;

public class Program
{
    public static void Main(string[] args)
    {
        List<int> ls=new List<int>{1,4,5};
        Dictionary<int,int> dict=new Dictionary<int, int>{{1,20000},{4,40000},{5,15000}};
            int total=0;
            foreach(int i in ls)
        {
            if(dict.ContainsKey(i)){
            total+=dict[i];
            }
            
        }
        Console.WriteLine(total);
            
        }
}


using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
	public static void Main(string[] args)
	{
		List<string> ls = new List<string> {"Pen","Book","Pen","Pencil","Book"};
		List<string> Dup = ls.GroupBy(x => x).Where(x =>x.Count() > 1).Select(x=>x.Key).ToList();
		
		Console.Write(string.Join(", ",Dup));
	}
}

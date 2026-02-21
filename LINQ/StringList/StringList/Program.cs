using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
	public static void Main(string[] args)
	{
		List<string> ls = new List<string>
		{
			 "Ravi , 87" ,
			"Kumar , 98" ,
			"Arun , 92"
		};
		
		var TopScorer = ls.Select(x => new
		{
			Name = x.Split(",")[0].Trim(),
			Marks = int.Parse(x.Split(",")[1])
		}).OrderByDescending(x=>x.Marks).Take(3).Select(x=>x.Name).ToList();
		foreach(var i in TopScorer)
		{
			Console.WriteLine(i);
		}
		

	}
}
using System;
using DT;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        
        Dictionary<int, string> emptyDict = DialingCodes.GetEmptyDictionary();
        Console.WriteLine("Empty dictionary count: " + emptyDict.Count);

        
        Dictionary<int, string> existingDict = DialingCodes.GetExistingDictionary();
        Console.WriteLine("\nExisting Dictionary:");
        foreach (var item in existingDict)
        {
            Console.WriteLine($"Code: {item.Key}, Country: {item.Value}");
        }

       
        Dictionary<int, string> newDict =
            DialingCodes.AddCountryToEmptyDictionary(91, "India");
        Console.WriteLine("\nAdded to empty dictionary:");
        foreach (var item in newDict)
        {
            Console.WriteLine($"Code: {item.Key}, Country: {item.Value}");
        }

       
        DialingCodes.AddCountryToExistingDictionary(existingDict, 44, "United Kingdom");

       
        string country = DialingCodes.GetCountryNameFromDictionary(existingDict, 44);
        Console.WriteLine("\nCountry for code 44: " + country);

        
        Console.WriteLine("Does code exist? " +
            DialingCodes.CheckCodeExists(existingDict, 44));

       
        DialingCodes.UpdateDictionary(existingDict, 3, "Republic of India");

       
        DialingCodes.RemoveCountryFromDictionary(existingDict, 2);

       
        Console.WriteLine("\nUpdated Dictionary:");
        foreach (var item in existingDict)
        {
            Console.WriteLine($"Code: {item.Key}, Country: {item.Value}");
        }

        string longest = DialingCodes.FindLongestCountryName(existingDict);
        Console.WriteLine("\nLongest country name: " + longest);
    }
}

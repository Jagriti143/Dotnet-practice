using System;
using System.Collections.Generic;
public class Bike
{
    public string Model {get;set;}
    public string Brand {get;set;}
    public int PricePerDay{get;set;}
}

public class BikeUtility
{
    public static SortedDictionary<int, Bike> bikeDetails =
        new SortedDictionary<int, Bike>();

    public void AddBikeDetails(string model, string brand, int price)
    {
        int bikeId = bikeDetails.Count + 1;

        Bike bike = new Bike();
        bike.Model = model;
        bike.Brand = brand;
        bike.PricePerDay = price;

        bikeDetails.Add(bikeId, bike);
    }

    public SortedDictionary<string, List<Bike>> GroupBikesByBrand()
    {
        SortedDictionary<string, List<Bike>> bikesByBrand =
            new SortedDictionary<string, List<Bike>>();

        foreach (Bike bike in bikeDetails.Values)
        {
            if (!bikesByBrand.ContainsKey(bike.Brand))
            {
                bikesByBrand[bike.Brand] = new List<Bike>();
            }

            bikesByBrand[bike.Brand].Add(bike);
        }

        return bikesByBrand;
    }
}


class Program
{
    static void Main()
    {
        BikeUtility bikeUtility = new BikeUtility();

        while (true)
        {
            Console.WriteLine("1. Add Bike Details");
            Console.WriteLine();
            Console.WriteLine("2. Group Bikes By Brand");
            Console.WriteLine();
            Console.WriteLine("3. Exit");
            Console.WriteLine();
            Console.WriteLine("Enter your choice");
            Console.WriteLine();

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine();
                Console.WriteLine("Enter the model");
                string model = Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine("Enter the brand");
                string brand = Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine("Enter the price per day");
                int price = int.Parse(Console.ReadLine());

                bikeUtility.AddBikeDetails(model, brand, price);

                Console.WriteLine();
                Console.WriteLine("Bike details added successfully");
                Console.WriteLine();
            }
            else if (choice == 2)
            {
                SortedDictionary<string, List<Bike>> result =
                    bikeUtility.GroupBikesByBrand();

                Console.WriteLine();
                foreach (var brandGroup in result)
                {
                    Console.WriteLine(brandGroup.Key);
                    Console.WriteLine();

                    foreach (Bike bike in brandGroup.Value)
                    {
                        Console.WriteLine(bike.Model);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                break;
            }
        }
    }
}
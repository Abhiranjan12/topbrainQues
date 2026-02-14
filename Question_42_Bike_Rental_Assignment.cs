/*
Question 42
Bike Rental Assignment

Description:
A bike rental shop wants a simple console-based application to manage bike details
such as model, brand, and price per day, and also to group bikes based on their brand.
This application helps the shop organize its inventory efficiently and easily view
bikes from the same brand.

Functionalities:

In class Question_42:
- public static SortedDictionary<int, Bike> bikeDetals
  This dictionary stores bike details with a unique integer key.

In class Bike:
Properties:
- string Model
- string Brand
- int PricePerDay

In class BikeUtility:
Methods:
1. public void AddBikeDetails(string model, string brand, int pricePerDay)
   Adds bike details to the dictionary.
   Key is generated as (current count + 1).

2. public SortedDictionary<string, List<Bike>> GroupBikesByBrand()
   Groups bikes based on brand and returns the result as a SortedDictionary.

The Main method:
- Displays menu
- Gets user input
- Calls appropriate methods
- Displays output as per the given sample input/output.
*/

using System;
using System.Collections.Generic;

public class Question_42
{
    // SortedDictionary to store bike details
    public static SortedDictionary<int, Bike> bikeDetals =
        new SortedDictionary<int, Bike>();

    public static void main()
    {
        int choice = 0;
        BikeUtility obj = new BikeUtility();

        do
        {
            Console.WriteLine("1. Add Bike Details");
            Console.WriteLine("2. Group Bikes By Brand");
            Console.WriteLine("3. Exit");
            Console.WriteLine("Enter your choice");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter the model : ");
                    string model = Console.ReadLine();

                    Console.Write("Enter the brand : ");
                    string brand = Console.ReadLine();

                    Console.Write("Enter the price per day : ");
                    int price = Convert.ToInt32(Console.ReadLine());

                    obj.AddBikeDetails(model, brand, price);
                    Console.WriteLine("Bike details added successfully");
                    break;

                case 2:
                    SortedDictionary<string, List<Bike>> result =
                        obj.GroupBikesByBrand();

                    foreach (var item in result.Keys)
                    {
                        Console.Write(item + " ");
                        foreach (var bike in result[item])
                        {
                            Console.Write(bike.Model + " ");
                        }
                        Console.WriteLine();
                    }
                    break;

                case 3:
                    // Exit
                    break;

                default:
                    Console.WriteLine("Wrong Choice");
                    break;
            }
        }
        while (choice != 3);
    }
}

// Bike class
public class Bike
{
    public string Model { get; set; }
    public int PricePerDay { get; set; }
    public string Brand { get; set; }
}

// Utility class
public class BikeUtility
{
    // Adds bike details to the dictionary
    public void AddBikeDetails(string model, string brand, int pricePerDay)
    {
        Bike bike = new Bike
        {
            Model = model,
            Brand = brand,
            PricePerDay = pricePerDay
        };

        int key = Question_42.bikeDetals.Count + 1;
        Question_42.bikeDetals.Add(key, bike);
    }

    // Groups bikes by brand
    public SortedDictionary<string, List<Bike>> GroupBikesByBrand()
    {
        SortedDictionary<string, List<Bike>> dict =
            new SortedDictionary<string, List<Bike>>();

        foreach (var bike in Question_42.bikeDetals.Values)
        {
            if (!dict.ContainsKey(bike.Brand))
            {
                dict[bike.Brand] = new List<Bike>();
            }

            dict[bike.Brand].Add(bike);
        }

        return dict;
    }
}

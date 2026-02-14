using System;
using System.Collections.Generic;
using System.Linq;

public class Question_Number_27
{  
    // Hardcoded item details (already provided in template)
    public static SortedDictionary<string, long> itemDetails =
        new SortedDictionary<string, long>()
        {
            { "Pen", 150 },
            { "Notebook", 300 },
            { "Pencil", 100 },
            { "Eraser", 50 }
        };

    // Find item details by sold count
    public static SortedDictionary<string, long> FindItemDetails(long soldCount)
    {
        SortedDictionary<string, long> result = new SortedDictionary<string, long>();

        foreach (var item in itemDetails)
        {
            if (item.Value == soldCount)
            {
                result.Add(item.Key, item.Value);
            }
        }
        return result;
    }

    // Find minimum and maximum sold items
    public static List<string> FindMinandMaxSoldItems()
    {
        List<string> result = new List<string>();

        long minValue = itemDetails.Values.Min();
        long maxValue = itemDetails.Values.Max();

        string minItem = itemDetails.First(x => x.Value == minValue).Key;
        string maxItem = itemDetails.First(x => x.Value == maxValue).Key;

        result.Add(minItem);
        result.Add(maxItem);

        return result;
    }

    // Sort items by sold count
    public static Dictionary<string, long> SortByCount()
    {
        Dictionary<string, long> sortedResult = new Dictionary<string, long>();

        foreach (var item in itemDetails.OrderBy(x => x.Value))
        {
            sortedResult.Add(item.Key, item.Value);
        }
        return sortedResult;
    }

    static void Main(string[] args)
    {
        // Hardcoded sold count
        long soldCount = 100;

        // Call FindItemDetails
        SortedDictionary<string, long> foundItems = FindItemDetails(soldCount);

        if (foundItems.Count == 0)
        {
            Console.WriteLine("Invalid sold count");
        }
        else
        {
            Console.WriteLine("Item Details:");
            foreach (var item in foundItems)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
        }

        // Find minimum and maximum sold items
        List<string> minMaxItems = FindMinandMaxSoldItems();
        Console.WriteLine("Minimum Sold Item: " + minMaxItems[0]);
        Console.WriteLine("Maximum Sold Item: " + minMaxItems[1]);

        // Sort items by sold count
        Dictionary<string, long> sortedItems = SortByCount();
        Console.WriteLine("Items Sorted by Sold Count:");
        foreach (var item in sortedItems)
        {
            Console.WriteLine(item.Key + " : " + item.Value);
        }
    }
}

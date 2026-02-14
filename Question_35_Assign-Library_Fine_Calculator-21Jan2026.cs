/*
Question 35
Assign-Library Fine Calculator-21Jan2026

Description
Library Fine Calculator

Scenario: JustRental is a Leading  library which  deals in renting Books,DVD's and Journal's to there clients.
They needs a System to be developed to calculate late fines for returned books,Dvd's & Journals.

Problem: Create a program that calculates fines based on:

Books: $0.50 per day late
DVDs: $1.00 per day late
Journals: $0.25 per day late
No fine if returned within 3-day grace period
Maximum fine cap: $20 per item
50% discount for students
Input: Item type (B, D, J), Days late, User type (S for student, R for regular)
Output:
=== LIBRARY FINE CALCULATOR ===

Item Type: Book
User Type: Regular
Days Late: 5
Daily Fine Rate: $0.50
Calculated Fine: $1.00
------------------------
Item Type: Book
User Type: Student
Days Late: 5
Daily Fine Rate: $0.50
Calculated Fine: $0.50
------------------------
Item Type: DVD
User Type: Regular
Days Late: 2
Daily Fine Rate: $1.00
No fine - within grace period
------------------------
Item Type: DVD
User Type: Regular
Days Late: 10
Daily Fine Rate: $1.00
Calculated Fine: $7.00
------------------------
Item Type: Journal
User Type: Regular
Days Late: 50
Daily Fine Rate: $0.25
Calculated Fine: $11.75
------------------------
Item Type: Journal
User Type: Student
Days Late: 7
Daily Fine Rate: $0.25
Calculated Fine: $0.50
------------------------
*/

using System;
using System.Collections.Generic;

public class LibraryFineCalculator
{
    public static void Main()
    {
        Console.WriteLine("=== LIBRARY FINE CALCULATOR ===\n");

        // Sample data: ItemType, DaysLate, UserType
        List<(char, int, char)> lateItems = new List<(char, int, char)>
        {
            ('B', 5, 'R'),   // Book, 5 days, Regular
            ('B', 5, 'S'),   // Book, 5 days, Student
            ('D', 2, 'R'),   // DVD, 2 days (grace period)
            ('D', 10, 'R'),  // DVD, 10 days
            ('J', 50, 'R'),  // Journal, 50 days (max cap)
            ('J', 7, 'S')    // Journal, 7 days, Student
        };

        foreach (var item in lateItems)
        {
            CalculateAndDisplayFine(item.Item1, item.Item2, item.Item3);
            Console.WriteLine("------------------------");
        }
    }

    static void CalculateAndDisplayFine(char itemType, int daysLate, char userType)
    {
        string itemName = GetItemName(itemType);
        string userTypeName = GetUserTypeName(userType);
        double fineRate = GetFineRate(itemType);
        double fine = CalculateFine(itemType, daysLate, userType);

        Console.WriteLine($"Item Type: {itemName}");
        Console.WriteLine($"User Type: {userTypeName}");
        Console.WriteLine($"Days Late: {daysLate}");
        Console.WriteLine($"Daily Fine Rate: ${fineRate:F2}");
        if (fine == 0)
        {
            Console.WriteLine("No fine - within grace period");
        }
        else
        {
            Console.WriteLine($"Calculated Fine: ${fine:F2}");
        }

    }

    static double CalculateFine(char itemType, int daysLate, char userType)
    {
        // Check grace period
        if (daysLate <= 3)
        {
            return 0;
        }


        // Calculate base fine
        double dailyRate = (itemType == 'B') ? 0.5 : (itemType == 'D') ? 1.0 : 0.25;
        daysLate -= 3;
        double fine = dailyRate * daysLate;

        // Apply maximum cap
        double maxFine = 20.00;
        if (fine > maxFine)
        {
            fine = maxFine;
        }

        // Apply student discount
        if (userType == 'S')
        {
            fine = fine - (fine * 0.5);
        }
        return Math.Round(fine, 2);
    }

    static double GetFineRate(char itemType)
    {
        return itemType switch
        {
            'B' => 0.50,  // Book
            'D' => 1.00,  // DVD
            'J' => 0.25,  // Journal
            _ => 0.00
        };
    }

    static string GetItemName(char itemType)
    {
        return itemType switch
        {
            'B' => "Book",
            'D' => "DVD",
            'J' => "Journal",
            _ => "Unknown"
        };
    }

    static string GetUserTypeName(char userType)
    {
        return userType switch
        {
            'S' => "Student",
            'R' => "Regular",
            _ => "Unknown"
        };
    }
}
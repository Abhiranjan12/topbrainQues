/*
Question 31
Assign-Check Leap Year
Description
Write a C# program that determines if a given year is a leap year.
The program should prompt the user to enter a year, use control statements to determine if the year is a leap year, and print whether the year is a leap year or not.

Requirements:

The program should read a year from the user.

The program should implement the logic to determine if the year is a leap year using control statements.

A leap year is defined as:

Divisible by 4.

If divisible by 100, it should also be divisible by 400.

The program should print whether the year is a leap year or not.
*/

using System;
public class Solution
{
    /// <summary>
    /// Checks if a year is a leap year and prints the result.
    /// </summary>
    /// <param name="year">The year to check</param>
    public static void PrintLeapYearResult(int year)
    {
        if (IsLeapYear(year))
        {
            Console.WriteLine(year + " is a leap year.");
        }
        else
        {
            Console.WriteLine(year + " is not a leap year.");
        }
    }

    /// <summary>
    /// Determines whether a given year is a leap year.
    /// </summary>
    /// <param name="year">The year to check</param>
    /// <returns>True if the year is a leap year, false otherwise</returns>
    static bool IsLeapYear(int year)
    {
        // implement code here
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            return true;
        }

        return false;
    }
}
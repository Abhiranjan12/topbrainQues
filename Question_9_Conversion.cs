/*
Question 9
Conversion

Description
Write a method that converts feet to centimeters.
Use: 1 foot = 30.48 cm
Round the result to 2 decimal places (MidpointRounding.AwayFromZero).

Input: feet (int)
Output: centimeters (double)

Constraints:
0 <= feet <= 1e6
*/

using System;

class Question_Number_9
{
    public static void main()
    {
        int feet = 5;

        double centimeters = feet * 30.48;
        centimeters = Math.Round(centimeters, 2, MidpointRounding.AwayFromZero);

        Console.WriteLine(centimeters);
    }
}

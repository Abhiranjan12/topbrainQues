/*
Question 8
Mid point Rounding

Description
Write a method that returns the area of a circle for a given radius.
Round the result to 2 decimal places (MidpointRounding.AwayFromZero).

Input: radius (double)
Output: area (double)

Constraints:
0 <= radius <= 1e6
*/

using System;

class Question_Number_8
{
    public static void main()
    {
        double radius = 5;

        double area = Math.PI * radius * radius;
        area = Math.Round(area, 2, MidpointRounding.AwayFromZero);

        Console.WriteLine(area);
    }
}

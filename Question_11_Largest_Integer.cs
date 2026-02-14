/*
Question 11
Largest Integer

Description
Write a method that returns the largest of three integers using conditional logic.

Input: a (int), b (int), c (int)
Output: largest (int)

Constraints:
-1e9 <= a,b,c <= 1e9
*/

using System;

class Question_Number_11
{
    public static void main()
    {
        int a = 25;
        int b = 40;
        int c = 15;

        int largest;

        if (a >= b && a >= c)
            largest = a;
        else if (b >= a && b >= c)
            largest = b;
        else
            largest = c;

        Console.WriteLine(largest);
    }
}

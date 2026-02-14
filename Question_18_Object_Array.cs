/*
Question 18
Object Array

Description
Given an object array that may contain ints, strings, bools, nulls, etc., sum only the integer values.
Use pattern matching (is int x).

Input: values (object[])
Output: sum (int)

Constraints:
0 <= values.Length <= 1e5
*/

using System;

class Question_Number_18
{
    public static void main()
    {
        object[] values = { 10, "Hello", 20, true, null, 30, 5.5, false, 40 };

        int sum = 0;

        foreach (object val in values)
        {
            if (val is int x)
            {
                sum += x;
            }
        }

        Console.WriteLine("Sum of integers: " + sum);
    }
}

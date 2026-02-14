/*
Question 15
Parsing

Description
Given an array of strings, sum only the values that can be parsed as 32-bit integers.
Use int.TryParse (ignore invalid and overflow values).

Input: tokens (string[])
Output: sum (int)

Constraints:
0 <= tokens.Length <= 1e5
*/

using System;

class Question_Number_15
{
    public static void main()
    {
        string[] tokens = { "10", "20", "abc", "2147483647", "2147483648", "-5", "xyz" };

        int sum = 0;

        foreach (string s in tokens)
        {
            int value;
            if (int.TryParse(s, out value))
            {
                sum += value;
            }
        }

        Console.WriteLine(sum);
    }
}

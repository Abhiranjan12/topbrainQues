/*
Question 16
Greatest Common Divisor

Description
Compute the Greatest Common Divisor (GCD) of two non-negative integers using recursion (Euclid's algorithm).

Input: a (int), b (int)
Output: gcd (int)

Constraints:
0 <= a,b <= 2*10^9
*/

using System;

class Question_Number_16
{
    static int GCD(int a, int b)
    {
        if (b == 0)
            return a;
        return GCD(b, a % b);
    }

    public static void main()
    {
        int a = 48;
        int b = 18;

        int result = GCD(a, b);

        Console.WriteLine(result);
    }
}

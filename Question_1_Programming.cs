/*
Question 1
Programming

Description
In a lucky draw, contestants with ticket numbers having a special property are chosen as Lucky Winners.
Let S(n) be the sum of the digits of n. Example:
S(484) = 4 + 8 + 4 = 16
S(22) = 2 + 2 = 4
A non-prime positive integer x is called a Lucky Number if:
S(x × x) = S(x) × S(x)

Example: 22 is a Lucky Number because:
S(22) = 4
S(484) = 16
And 4 × 4 = 16 
You must find how many Lucky Numbers lie between m and n (inclusive).
Sample Input 20 30
Sample Output 4
*/

using System;
class Question_Number_1
{
    static int SumDigits(int n)
    {
        int sum = 0;
        while (n > 0)
        {
            sum += n % 10;
            n /= 10;
        }
        return sum;
    }

    static bool IsPrime(int n)
    {
        if (n <= 1) return false;
        if (n == 2) return true;
        if (n % 2 == 0) return false;

        for (int i = 3; i * i <= n; i += 2)
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }

    public static void main()
    {
        int m = 20;
        int n = 30;

        int count = 0;

        for (int i = m; i <= n; i++)
        {
            if (!IsPrime(i))
            {
                int s1 = SumDigits(i);
                int s2 = SumDigits(i * i);

                if (s2 == s1 * s1)
                    count++;
            }
        }

        Console.WriteLine(count);
    }
}

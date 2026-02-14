/*
Question 29
Prime Number Checker
Description
Accept a Number From User and Check Wether the number is Prime or Not
*/
using System;

public class Solution
{


    public static bool IsPrime(int num)
    {
        //Implement Logic here
        if (num < 2) return false;

        if (num == 2) return true;
        if (num % 2 == 0) return false;

        for (int i = 3; i * i <= num; i += 2)
        {
            if (num % i == 0) return false;
        }

        return true;
    }
}
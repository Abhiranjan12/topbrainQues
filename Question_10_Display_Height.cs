/*
Question 10
Display Height

Description
Given a person's height in centimeters, return the height category:
- "Short"  : height < 150
- "Average": 150 <= height < 180
- "Tall"   : height >= 180

Input: heightCm (int)
Output: category (string)

Constraints:
0 <= heightCm <= 300
*/

using System;

class Question_Number_10
{
    public static void main()
    {
        int heightCm = 170;

        string category;

        if (heightCm < 150)
            category = "Short";
        else if (heightCm < 180)
            category = "Average";
        else
            category = "Tall";

        Console.WriteLine(category);
    }
}

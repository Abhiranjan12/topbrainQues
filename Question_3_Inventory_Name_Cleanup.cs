/*
Question 3
Inventory Name Cleanup

Description
Inventory Name Cleanup
Problem
Given a product name string, remove:

·        All duplicate consecutive characters

·        Trim extra spaces

·        Convert to TitleCase

Input
" llapppptop bag "

Output
"Laptop Bag"
*/
using System;
using System.Globalization;
using System.Text;

class Question_Number_3
{
    public static void main()
    {
        string input = " llapppptop bag ";

        string trimmed = input.Trim().ToLower();

        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < trimmed.Length; i++)
        {
            if (i == 0 || trimmed[i] != trimmed[i - 1])
                sb.Append(trimmed[i]);
        }

        string cleaned = sb.ToString();

        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        string result = textInfo.ToTitleCase(cleaned);

        Console.WriteLine(result);
    }
}

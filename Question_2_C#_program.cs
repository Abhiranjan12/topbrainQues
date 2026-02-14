/*
Question 2
C# program

Description
Mahirl and Alphabets and Vowels
Mahirl's uncle Sam has just taught her about vowels.
To test her understanding, he gave her the following assignment.

He gave her two words.
Mahirl needs to:

Task 1: Remove Common Consonants
Remove all consonants from the first word that also appear in the second word.

While comparing characters, case should not be considered.
(Example: 'A' and 'a' are considered the same.)

Task 2: Remove Consecutive Duplicate Characters
After deleting the common consonants:
If there are two or more consecutive identical characters, only the first occurrence must be kept and all others deleted.

Your job is to help Mahirl complete this assignment.

Input Format
Input consists of two strings:
The first word and the second word.

Maximum string length: 50 characters.

Strings contain only uppercase and lowercase English letters.

Comparisons are case-insensitive.

Output Format
Output the final processed string after applying both rules.
*/

using System;
using System.Text;

class Question_Number_2
{
    static bool IsVowel(char c)
    {
        c = char.ToLower(c);
        return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
    }

    public static void main()
    {
        string first = "Mahirl";
        string second = "Sam";

        string secondLower = second.ToLower();
        StringBuilder filtered = new StringBuilder();

        foreach (char c in first)
        {
            char lower = char.ToLower(c);

            if (!IsVowel(c) && secondLower.Contains(lower))
                continue;

            filtered.Append(c);
        }

        StringBuilder result = new StringBuilder();

        for (int i = 0; i < filtered.Length; i++)
        {
            if (i == 0 || filtered[i] != filtered[i - 1])
                result.Append(filtered[i]);
        }

        Console.WriteLine(result.ToString());
    }
}

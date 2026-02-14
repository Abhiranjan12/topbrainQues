/*
Question
38
FlipKey23JAN
Description

public string CleanseAndInvert(string input)


This method takes a word as input and performs a series of transformations and return a customized format of string. The transformation logic includes:

1) The input must not be null, and it must contain at least 6 characters long. If it is shorter or null, the function should return an empty string.

2)The input must not contain any space, digit or special characters. If not, the function should return an empty string.

Password Generation Logic:

Convert the input to lowercase.
Remove all characters whose ASCII values are even numbers.
Reverse the remaining characters.
In the reversed string, convert characters that have even positioned character (0 based index) to uppercase. Refer to the sample input and output.
Return the generated key. 
*/

static string CleanseAndInvert(string str)
{
    if (string.IsNullOrEmpty(str) || str.Length < 6)
    {
        return string.Empty;
    }

    if (string.IsNullOrWhiteSpace(str))
    {
        return "";
    }
    foreach (char c in str)
    {
        if (!char.IsLetter(c))
        {
            return "";
        }
    }
    str = str.ToLower();

    var res = str.Where(x => ((int)x % 2 != 0)).ToArray();

    string rev = "";
    for (int i = res.Length - 1; i >= 0; i--)
    {
        rev += res[i];
    }

    string newStr = "";
    for (int i = 0; i < rev.Length; i++)
    {
        if (i % 2 == 0)
        {
            newStr += char.ToUpper(rev[i]);
        }
        else
        {
            newStr += rev[i];
        }
    }
    return newStr;
}

{

    string result = CleanseAndInvert("abcdef");
    if (result.Length == 0)
    {
        System.Console.WriteLine("invalid");
    }
    else
    {
        System.Console.WriteLine("Generated String is: " + result);
    }
}

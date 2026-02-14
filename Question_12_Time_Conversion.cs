/*
Question 12
Time Conversion

Description
Convert a number of seconds into a string formatted as m:ss.
Seconds must be 2 digits (leading zero if needed).

Input: totalSeconds (int)
Output: formatted (string)

Examples:
125 -> "2:05"
60  -> "1:00"

Constraints:
0 <= totalSeconds <= 1e9
*/

using System;

class Question_Number_12
{
    static void Main()
    {
        int totalSeconds = 125;   // example input

        int minutes = totalSeconds / 60;
        int seconds = totalSeconds % 60;

        string formattedTime = minutes + ":" + seconds.ToString("D2");

        Console.WriteLine(formattedTime);
    }
}
    

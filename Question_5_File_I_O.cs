/*
Question 5
File I/O

Description
File I/O – Read & Filter Logs
You have a log file containing mixed INFO, ERROR, WARN logs.
Extract only ERROR logs and save to a new file.

Input
log.txt

Output
error.txt
*/

using System;
using System.IO;

class Question_Number_5
{
    public static void main()
    {
        string inputPath = "log.txt";
        string outputPath = "error.txt";

        if (!File.Exists(inputPath))
            return;

        string[] lines = File.ReadAllLines(inputPath);

        using (StreamWriter writer = new StreamWriter(outputPath))
        {
            foreach (string line in lines)
            {
                if (line.Contains("ERROR"))
                {
                    writer.WriteLine(line);
                }
            }
        }

        Console.WriteLine("Done");
    }
}

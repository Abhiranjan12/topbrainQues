/*
Question 24 - String Format

Description
Given strings formatted as "Name:Score", build a list of Student objects.
Filter students with Score >= minScore, sort by Score descending then Name ascending,
and serialize the result to a JSON array using System.Text.Json.

Use a C# record for Student.

Input: items (string[]), minScore (int)
Output: json (string)

Constraints:
0 <= items.Length <= 2*10^5
*/

using System;
using System.Collections.Generic;
using System.Text.Json;

record Student(string Name, int Score);

class Question_Number_24
{
    public static void main()
    {
        string[] items =
        {
            "John:85",
            "Alice:92",
            "Mark:78",
            "Bob:92"
        };

        int minScore = 80;

        List<Student> students = new List<Student>();

        foreach (var item in items)
        {
            string[] parts = item.Split(':');
            students.Add(new Student(parts[0], int.Parse(parts[1])));
        }

        students = students
            .FindAll(s => s.Score >= minScore);

        students.Sort((a, b) =>
        {
            int scoreCompare = b.Score.CompareTo(a.Score);
            if (scoreCompare != 0)
                return scoreCompare;
            return a.Name.CompareTo(b.Name);
        });

        string json = JsonSerializer.Serialize(students);

        Console.WriteLine(json);
    }
}
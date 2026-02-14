/*
Question 6
Dictionary

Description
Dictionary Lookup
Given a dictionary of (EmployeeId, Salary) and a list of EmployeeIds, return the total salary.

Input
Ids: {1, 4, 5}
Dictionary: {1:20000, 4:40000, 5:15000}

Output
75000
*/

using System;
using System.Collections.Generic;

class Question_Number_6
{
    public static void main()
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        dict[1] = 20000;
        dict[4] = 40000;
        dict[5] = 15000;

        int[] ids = { 1, 4, 5 };

        int total = 0;

        foreach (int id in ids)
        {
            int salary;
            if (dict.TryGetValue(id, out salary))
            {
                total += salary;
            }
        }

        Console.WriteLine(total);
    }
}

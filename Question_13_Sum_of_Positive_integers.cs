/*
Question 13
Sum of Positive integers

Description
Given an integer array, sum only positive numbers until you reach 0.
- If an element is 0, stop processing (break).
- If an element is negative, ignore it (continue).

Input: nums (int[])
Output: sum (int)

Constraints:
0 <= nums.Length <= 1e5
-1e9 <= nums[i] <= 1e9
*/

using System;
class Question_Number_13
{
    public static void main()
    {
        int[] nums = { 5, -2, 10, 3, 0, 8, 4 };

        int sum = 0;

        foreach (int n in nums)
        {
            if (n == 0)
                break;

            if (n < 0)
                continue;

            sum += n;
        }

        Console.WriteLine(sum);
    }
}

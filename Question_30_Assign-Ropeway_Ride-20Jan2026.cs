/*
Question 30
Assign-Ropeway Ride-20Jan2026
Description
One day, Ravi and Suraj planned to go forRaigad by Ropeway When they arrived, the Ticket Checker manually checked their age and weight, which made him tired due to noting all the details. After completing the skydive, they returned home. Now, Sam is attempting to write the eligibility criteria checking code for RopeWay in C#.

Help him meet the given criteria by using your C# coding skills. 
Functionality :
In Program class, implement the below given method.

Method
public static void Main(string[ ] args)

Description
This method is used to check the eligibility criteria to see who is eligible to do skydiving and who is not. In this method, get the age and weight values from the user.
If the age is greater than or equal to 18 and the weight is less than 90, then display "You are allowed to Take Ropeway Ride". Else, display "You are not allowed to Take Ropeway Ride".

Note :
·        Keep the method and class as public.
·        Please read the method rules clearly.
·        Do not use Environment.Exit() to terminate the program.
·        Do not change the given code template.

Summary :
He has learned about control structures (if - else statement) in C#.
·        Use if to specify a block of code to be executed if a specified condition is true
·        Use else to specify a block of code to be executed if the same condition is false  
*/

using System;

public class Solution
{
    public static string CheckEligibility(int age, int weight)
    {
        string ans = "";
        if(age>=18 && weight<90){
            ans = "You are allowed to Take Ropeway Ride";
        }else{
            ans = "You are not allowed to Take Ropeway Ride";
        }
        return ans;
    }
}
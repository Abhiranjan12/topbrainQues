/*
Question
39
Smart Classroom Attendance Validator
Description
A smart classroom system validates student attendance based on multiple conditions to prevent proxy attendance and late entries.

Attendance is considered valid only if all the following rules are satisfied:

The student logs in within the first 10 minutes of the class
The student is present for at least 45 minutes
Biometric verification is successful
Given the login time, total duration of presence, and biometric verification status, determine whether the student’s attendance should be marked as valid.

loginMinute — minutes after class start when the student logged in
totalMinutesPresent — total minutes the student was present
biometricVerified — biometric verification status (true or false)
Example 1 :
Input :

5, 50, true
Output :

true
Example 2 :
Input :

15, 60, true
Output :

false
Constraints
0 ≤ loginMinute ≤ 60
0 ≤ totalMinutesPresent ≤ 180
biometricVerified is either true or false
*/

using System;

public class Solution
{
    public bool IsAttendanceValid(
        int loginMinute,
        int totalMinutesPresent,
        bool biometricVerified
    )
    {
        if (loginMinute > 10 || totalMinutesPresent < 45 || !biometricVerified)
        {
            return false;
        }

        return true;
    }
}

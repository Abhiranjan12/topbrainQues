/*
Question 25
Arithmetic Expressions

Description
Evaluate a simple arithmetic expression of the form "a op b" (spaces required),
where op is one of: +, -, *, /.

Return:
- the integer result as a string for valid expressions
- "Error:DivideByZero"   if b==0 for division
- "Error:InvalidNumber"  if a or b is not an int
- "Error:UnknownOperator" if op is not one of + - * /
- "Error:InvalidExpression" if format is invalid

Input: expression (string)
Output: result (string)

Constraints:
1 <= expression.Length <= 100
*/

using System;

class Question_Number_25
{
    public static void main()
    {
        string expression = "10 / 2";
        string result;
        string[] parts = expression.Split(' ');
        if (parts.Length != 3)
        {
            result = "Error:InvalidExpression";
        }
        else
        {
            int a, b;
            if (!int.TryParse(parts[0], out a) || !int.TryParse(parts[2], out b))
            {
                result = "Error:InvalidNumber";
            }
            else
            {
                string op = parts[1];

                if (op == "+")
                {
                    result = (a + b).ToString();
                }
                else if (op == "-")
                {
                    result = (a - b).ToString();
                }
                else if (op == "*")
                {
                    result = (a * b).ToString();
                }
                else if (op == "/")
                {
                    if (b == 0)
                    {
                        result = "Error:DivideByZero";
                    }
                    else
                    {
                        result = (a / b).ToString();
                    }
                }
                else
                {
                    result = "Error:UnknownOperator";
                }
            }
        }

        Console.WriteLine(result);
    }
}
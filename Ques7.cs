// using System;

// class Program
// {
//     public static void Method1(ref int num1, ref int num2)
//     {
//         num1 = num1 + num2;
//         num2 = num1 - num2;
//         num1 = num1 - num2;
//     }
//     public static void Method2(int n1, int n2, out int x, out int y)
//     {
//         x = n2;
//         y = n1;
//     }
//     public static void Main(string[] args)
//     {
//         int num1 = int.Parse(Console.ReadLine());
//         int num2 = int.Parse(Console.ReadLine());
//         Method1(ref num1, ref num2);
//         Console.WriteLine(num1);
//         Console.WriteLine(num2);
//         int x, y;
//         Method2(num1, num2, out x, out y);
//         Console.WriteLine(x);
//         Console.WriteLine(y);
//     }
// }

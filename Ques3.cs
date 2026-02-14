// using System;
// using System.Text;

// class Program
// {
//     public static void Main(string[] args)
//     {
//         string s = Console.ReadLine();
//         string res = string.Empty;
//         for (int i = 0; i < s.Length; i++)
//         {
//             if (i == 0 || s[i] != s[i - 1])
//                 res += s[i];
//         }
//         res = res.Trim();
//         string[] arr = res.Split(" ");
//         string ret = string.Empty;
//         for (int i = 0; i < arr.Length; i++)
//         {
//             arr[i] = char.ToUpper(arr[i][0]) + arr[i].Substring(1).ToLower();
//             ret += arr[i] + " ";
//         }
//         Console.WriteLine(ret.Trim());
//     }
// }

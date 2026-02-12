// using System;
// using System.Collections.Generic;
// class Program
// {
//     public static bool vowel(char c)
//     {
//         c = char.ToLower(c);
//         return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
//     }
//     public static void Main(string[] args)
//     {
//         string s1 = Console.ReadLine();
//         string s2 = Console.ReadLine();
//         HashSet<char> hs = new HashSet<char>();
//         foreach (char it in s2) hs.Add(char.ToLower(it));
//         string s = string.Empty;
//         foreach (char it in s1)
//         {
//             char c = char.ToLower(it);
//             if (!vowel(c) && hs.Contains(c)) continue;
//             s += it;
//         }
//         string res = string.Empty;
//         for (int i = 0; i < s.Length; i++)
//         {
//             if (i == 0 || s[i] != s[i - 1])
//                 res += s[i];
//         }
//         Console.WriteLine(res);
//     }
// }

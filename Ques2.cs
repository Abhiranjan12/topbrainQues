// using System;
// class Program
// {
//     public static bool IsPrime(int num)
//     {
//         if (num <= 1) return false;
//         if (num == 2) return true;
//         if (num % 2 == 0) return false;
//         for (int i = 3; i * i <= num; i += 2)
//         {
//             if (num % i == 0)
//                 return false;
//         }
//         return true;
//     }
//     public static int Sum(int num)
//     {
//         int sum=0;
//         while (num > 0)
//         {
//             sum=num%10;
//             num=num/10;
//         }
//         return sum;
//     }
//     public static void Main(string[] args)
//     {
//         int n1=int.Parse(Console.ReadLine());
//         int n2=int.Parse(Console.ReadLine());
//         int cnt=0;
//         for(int i = n1; i <= n2; i++)
//         {
//             if (!IsPrime(i))
//             {
//                 int s1=Sum(i);
//                 int s2=Sum(i*i);
//                 if(s2==s1*s1) cnt++;
//             }
//         }
//         Console.WriteLine(cnt);
//     }
// }
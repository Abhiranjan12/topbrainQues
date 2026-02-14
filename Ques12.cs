class Program
{
    public static void Main(string[] args)
    {
        int totalsecond=int.Parse(Console.ReadLine());
        Console.WriteLine((totalsecond/60).ToString()+":"+(totalsecond%60).ToString("D2"));
    }
}
using System;


namespace BoolExplore
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 4, 3, 2 };
            int userInterface = Convert.ToInt32(Console.ReadLine());
            bool check1 = userInterface <= a.Length;
            bool check2 = userInterface > 0;
            Console.WriteLine(check1);
            Console.WriteLine(check2);
            Console.WriteLine(a[userInterface - 1]);
        }
    }
}

using System;
using System.Globalization;
using System.Threading;

namespace Modul03
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            double a = 0, b = 0;
            Console.Write("---> a = "); a = Convert.ToDouble(Console.ReadLine());
            Console.Write("---> b = "); b = Convert.ToDouble(Console.ReadLine());
           
            string numberFormat = "C2";
            
            Console.WriteLine("---> a/b = " + (a/b).ToString(numberFormat));
        }
    }
}

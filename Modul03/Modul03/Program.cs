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

            double a = 0, b = 0, c = 0;
            Console.Write("---> a = "); a = Convert.ToDouble(Console.ReadLine());
            Console.Write("---> b = "); b = Convert.ToDouble(Console.ReadLine());
           
            string numberFormat = "#0.00 м3";

            //Степенуване
           
            c = Math.Pow(a, b);
            Console.WriteLine("\n---> a^b = " + (c).ToString(numberFormat));
            
            //Коренуване

            c = Math.Sqrt(b);
            Console.WriteLine("\n---> b^1/2 = " + (c).ToString(numberFormat));
            
            //Закръгления

            c = Math.Round(a/b);
            Console.WriteLine("\n---> a/b = " + (c).ToString());
        }
    }
}

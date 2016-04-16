using System;

namespace Test
{
    class Test
    {
        static void Main(string[] args)
        {
            string[] row = "6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49".Split(',');
            var r = new Random();
            int a1 = r.Next(6, 49);
            int a2 = r.Next(6, 49);
            int a3 = r.Next(6, 49);
            int a4 = r.Next(6, 49);
            int a5 = r.Next(6, 49);
            
            Console.WriteLine(row[a1] + " " + row[a1] + " " + row[a2] + " " + row[a3] + " " + row[a4] + " " + row[a5]);
            

            
        }
    }
}

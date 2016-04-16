using System;

namespace TableProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] table = new string[2, 3];
            
            //Въвеждане на първи ред
            table[0, 0] = "Георги"; table[0, 1] = "Иванов"; table[0, 2] = "33";

            //Въвеждане на втори ред
            table[1, 0] = "Иван"; table[1, 1] = "Георгиев"; table[1, 2] = "35";

            //Печат
            Console.WriteLine("Кой ред искате да видите: ");
            int rowNumber = Convert.ToInt32(Console.ReadLine()) - 1;
            
            Console.WriteLine((table[rowNumber,0][0]) + ". " + table[rowNumber,1] + ", " + table[rowNumber,2] +" г." );




            //string[] row = new string[3];

            //row[0] = "Ред 1";
            //row[1] = "Ред 2";
            //row[2] = "Ред 3";

            //Console.WriteLine("Масив row:" + row[0] + ", " + row[1] + ", " + row[2] + "\n");

            //string[] parse = "1,2,3,4,5,6,7,8,9".Split(',');
            //Console.WriteLine("Броят на цифрите в масива " + "1,2,3,4,5,6,7,8,9 e: " + parse.Length + "\n");

            //string list1 = string.Join(";", parse);
            //Console.WriteLine("Новият масив е: " + list1 + "\n");

        }
    }
}
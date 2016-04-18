using System;

namespace TableProject
{
    class Program
    {
        enum ti
        {
            name = 0, surname, age
        }

        static void Main(string[] args)
        {
            string[,] table = new string[2, 3];

            //Въвеждане на първи ред
            table[0, (int)ti.name] = "Георги"; table[0, (int)ti.surname] = "Иванов"; table[0, (int)ti.age] = "33";

            //Въвеждане на втори ред
            table[1, (int)ti.name] = "Иван"; table[1, (int)ti.surname] = "Георгиев"; table[1, (int)ti.age] = "35";

            //Печат
            Console.WriteLine("Кой ред искате да видите: ");
            int rowNumber = Convert.ToInt32(Console.ReadLine()) - 1;

            Console.WriteLine
                ((table[rowNumber, (int)ti.name][0]) + ". " +
                  table[rowNumber, (int)ti.surname] + ", " +
                  table[rowNumber, (int)ti.age] + " г.");




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
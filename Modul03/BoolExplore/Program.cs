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

            bool expression1 = check1 && check2; //Логическо И "&&"
            bool expression2 = check1 || check2; //Логичско ИЛИ "||"
            bool expression3 = !check1; //Отрицание "!"
            
            
            Console.WriteLine("Логическо И: " + expression1.ToString());
            Console.WriteLine("Логическо ИЛИ: " + expression2.ToString());
            Console.WriteLine("Логическо Отрицание на " + check1.ToString() + ": " + expression3);
                                          

            //Console.WriteLine(a[userInterface - 1]);
        }
    }
}

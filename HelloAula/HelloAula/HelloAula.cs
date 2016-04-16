using System;

namespace HelloAula
{
    class HelloAula
    {
        static void Main(string[] args)
        {
            string first1 = "Hello";
            string second1 = "World";
            object one = first1 + " " + second1;
            string third = (string)one;
            Console.WriteLine(third);

            Console.WriteLine("Въведете едно число или цифра:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Въведете една дума: ");
            string word = Console.ReadLine();
            Console.WriteLine(number.ToString().Length + word.Length);



            /*Декларирайте две променливи от тип string и им присвоете стойности "Hello" и "World". Декларирайте променлива от тип object и й присвоете стойността на конкатенацията на двете променливи от тип string (не изпускайте интервала по средата). Декларирайте трета променлива от тип string и я инициализирайте със стойността на променливата от тип object. ( Hint: Трябва да използвате type casting.)
             

             * Да се въведат от командния ред 1 число или цифра и 1 дума/стринг. След това да изведе дължината на получения стринг при конкатенация, тоест броя на символите в новополучения стринг при конкатенация. (Hint: Трябва да преобразувате int към String и след това да конкатениратe.) */
        }
    }
}

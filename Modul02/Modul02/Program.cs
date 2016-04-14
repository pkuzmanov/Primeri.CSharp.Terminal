using System;

namespace Modul02
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			//Дефиниране на променливи
			int a = 0, b = 0;
			int sum = 0;
			string programName = "Модул02 - Примери";
			string programVersion = "1.0";

			//Събиране на числа
			a = 5;
			b = 10;

			sum = a + b;

			//За програмата
			Console.WriteLine(programName);
			Console.WriteLine ("Версия: " + programVersion + "\n\n");

			//Писане в конзола
			Console.Write (a);
			Console.Write (" + ");
			Console.Write (b);
			Console.Write (" = ");
			Console.WriteLine (sum);

			//Допълнителни команди
			Console.WriteLine ("\nИзползване на +=");
			a += b;
			Console.WriteLine (a);

			Console.WriteLine ("\nИзползване на -=");
			a -= b;
			Console.WriteLine (a);

			Console.WriteLine ("\nИзползване на *=");
			a *= b;
			Console.WriteLine (a);

			Console.WriteLine ("\nИзползване на ++");
			a++;
			Console.WriteLine (a);

			Console.WriteLine ("\nСтандартно делене: " + (14 / 3).ToString());
			Console.WriteLine ("Остатък от делене: " + (14 % 3).ToString());



		}
	}
}
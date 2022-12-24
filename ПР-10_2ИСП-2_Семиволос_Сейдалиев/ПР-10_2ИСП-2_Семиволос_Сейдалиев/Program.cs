using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПР_10_2ИСП_2_Семиволос_Сейдалиев
{
    internal class Program
    {
        static void Sposob1()
		{
			Console.Write("Введите диапозон от a до b \nвведите a = ");
			double a = double.Parse(Console.ReadLine());
			Console.Write("введите b = ");
			double b = double.Parse(Console.ReadLine());
			Console.Write("Введите с каким шагом ");
			double dx = double.Parse(Console.ReadLine());
			double y, x = a;
			for (int i = 0; i < 35; i++) Console.Write("-");
			Console.WriteLine();
			Console.Write("\tx\t\ty");
			Console.WriteLine();
			for (int i = 0; i < 35; i++) Console.Write("-");
			Console.WriteLine();
			while (x <= b)
			{
				y = Math.Pow(x, 2) - 3;
				Console.WriteLine($"\t{x:f1}\t|\t{y:f1}");
				x += dx;
			}
			Console.ReadLine();
		}

		static void Sposob2()
		{
			Console.Write("Введите диапозон от a до b \nвведите a =  ");
			double a = double.Parse(Console.ReadLine());
			Console.Write("введите b = ");
			double b = double.Parse(Console.ReadLine());
			Console.Write("Введите с каким шагом ");
			double dx = double.Parse(Console.ReadLine());
			double y, x = a;
			for (int i = 0; i < 35; i++) Console.Write("-");
			Console.WriteLine();
			Console.Write("\tx\t|\t y");
			Console.WriteLine();
			for (int i = 0; i < 35; i++) Console.Write("-");
			Console.WriteLine();
			do
			{
				y = Math.Pow(x, 2) - 3;
				Console.WriteLine($"\t{x:f1}\t|\t{y:f1}");
				x += dx;
			} while (x <= b);
			Console.ReadLine();

		}
		static void Sposob3()
		{
			Console.Write("Введите диапозон от a до b \nвведите a = ");
			double a = double.Parse(Console.ReadLine());
			Console.Write("введите b = ");
			double b = double.Parse(Console.ReadLine());
			Console.Write("Введите с каким шагом ");
			double x, y, dx = double.Parse(Console.ReadLine());
			for (int i = 0; i < 35; i++) Console.Write("-");
			Console.WriteLine();
			Console.Write("\tx\t|\ty");
			Console.WriteLine();
			for (int i = 0; i < 35; i++) Console.Write("-");
			Console.WriteLine();
			for (x = a; x <= b; x += dx)
			{
				y = Math.Pow(x, 2) - 3;
				Console.WriteLine($"\t{x:f1}\t|\t{y:f1}");

			}
			Console.ReadLine();
		}

		public static void Main(string[] args)
		{
			 Console.Write("Введите каким способом хотите решить ");
			 int sposob = int.Parse(Console.ReadLine());
			 switch (sposob)
			 {
				case 1:
					Sposob1();
					break;
				case 2:
					Sposob2();
					break;
				case 3:
					Sposob3();
					break;
				default:
					Console.WriteLine("был введен не правильный метод");
					break;
			 }


		}
    }
}

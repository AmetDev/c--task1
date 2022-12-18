using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПР9_2ИСП2_Сейдалиев_Семиволос
{
    class MainClass
    {
        static double z1(double m1, double m2) //задача 1

        {
            if (m1 < m2) return m1;
            else return m2;

        }
        static void z2(double x) //задача 2

        {
            double y;
            
            if (x < -12)
            {
                y = 2 / (x - 7);
                Console.WriteLine("y = " + y);
            }
            else
            {
                if (x > -12 && x < 12)
                {

                    y = Math.Sqrt(x + 20);
                    Console.WriteLine("y = " + y);
                }

                else
                {
                    y = 1 / (15 - x) + 1;
                    Console.WriteLine("y = " + y);
                }
            }

        }

        static void z3(double a, double b) //задача 3
        {
            if (((Math.Pow(a, 2) + Math.Pow(a, 2) < 4) & (Math.Pow(a, 2) + b > 1) & (a < 0 & b > 0)) || (Math.Pow(a, 2) + Math.Pow(b, 2) < 1) & (a < 0 & b < 0))
                Console.WriteLine("X принадлежит ОДЗ");
            else
                Console.WriteLine("X не принадлежит ОДЗ");
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задачи ");
            int n = Convert.ToInt32(Console.ReadLine());
            double k1;   
            switch (n)
            {
                case 1:
                    Console.WriteLine("Введите два числа ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    double b = Convert.ToDouble(Console.ReadLine());
                    k1 = z1(a, b);
                    Console.WriteLine("Меньшее значение " + k1);
                    break;
                case 2:
                    Console.WriteLine("Введите x ");
                    int x = Convert.ToInt32(Console.ReadLine());
                    z2(x);
                    break;
                case 3:
                    Console.WriteLine("Введите точку");
                    double x2 = Convert.ToDouble(Console.ReadLine());
                    double y2 = Convert.ToDouble(Console.ReadLine());
                    z3(x2, y2); 
                    break;
            }
            Console.ReadKey();
        }
    }
}

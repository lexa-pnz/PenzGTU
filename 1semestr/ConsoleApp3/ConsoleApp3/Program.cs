using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
       
        static double CalcArea(double x, double y, double z)
        {
            double p,S;
            p = (x + y + z) / 2;
            S = Math.Sqrt(p * (p - x) * (p - y) * (p - z));
            return Math.Round (S,2);
        }

        static void CheckEqual(double x, double y, double z)
        {
            if ( (x == y) || (x == z) ||  (y == z) )
                Console.WriteLine("Треугольник равнобедренный");
            else
                Console.WriteLine("Треугольник не равнобедренный");
        }

        static void Case1()
        {
            Console.Clear();
            double a, b, c;
            do
            {
                Console.Write("Введите первую сторону ");
                try
                {
                    a = double.Parse(Console.ReadLine());
                }

                catch (Exception e)
                {
                    Error(e);
                    return;
                }

                Console.Write("Введите вторую сторону ");
                try
                {
                    b = double.Parse(Console.ReadLine());
                }

                catch (Exception e)
                {
                    Error(e);
                    return;
                }

                Console.Write("Введите третью сторону ");
                try
                {
                    c = double.Parse(Console.ReadLine());
                }

                catch (Exception e)
                {
                    Error(e);
                    return;
                }
                if ((a + b <= c) || (a + c <= b) || (b + c <= a))
                {
                    Console.WriteLine("Такого треугольника не существует");
                    Console.WriteLine("Повторите ввод");
                }
            }
            while ((a + b <= c) || (a + c <= b) || (b + c <= a));
            Console.WriteLine("Площадь треугольника равна {0}", CalcArea(a, b, c));
            CheckEqual(a, b, c);
            Console.WriteLine("\nНажмите клавишу для продолжения..\n");
            Console.ReadKey();
            Console.Clear();
        }

        static void Error(Exception er)
        {
            Console.WriteLine(er.Message);
            Console.WriteLine("Нажмите клавишу для продолжения..\n");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            int i = 0;
            while (i != 2)
            {
                Console.Clear();
                Console.WriteLine("Выберите пункт меню:");
                Console.WriteLine("1 - Вычисление площади треугольника");
                Console.WriteLine("2 - Выход");
                try
                {
                    i = int.Parse(Console.ReadLine());
                }

                catch (Exception e)
                {
                    Error(e);
                    return;
                }
                switch (i)
                {
                    case 1:
                        Case1();
                        break;
                    case 2:
                        break;
                }
            }
        }
    }
}

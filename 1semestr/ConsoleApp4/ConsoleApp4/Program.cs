using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {

        static void Error(Exception er)
        {
            Console.WriteLine(er.Message);
            Console.WriteLine("Нажмите клавишу для продолжения..\n");
            Console.ReadKey();
        }

        static void Case1()
        {
            Console.Clear();
            int n;
            double x,Sum=0;
            Console.WriteLine("Вычисление суммы ряда чисел");
            Console.Write("\nВведите n (Целое число): ");
            try
            {
                n = int.Parse(Console.ReadLine());
            }

            catch (Exception e)
            {
                Error(e);
                return;
            }

            Console.Write("Введите x: ");
            try
            {
                x = double.Parse(Console.ReadLine());
            }

            catch (Exception e)
            {
                Error(e);
                return;
            }

            for (int i= 1; i <= n; i++)
            {
                Sum = Sum + i / Math.Pow(x,i);
            }
            Console.WriteLine("Сумма ряда чисел = {0}\n", Sum);

            Console.WriteLine("Нажмите клавишу для продолжения..\n");
            Console.ReadKey();
            Console.Clear();

        }

        static void Case2()
        {
            Console.Clear();
            double[] arr;
            int a;
            Console.WriteLine("Замена отрицательных элементов на 0");
            Console.Write("\nВведите размер массива: ");
            try
            {
                a = int.Parse(Console.ReadLine());
            }

            catch (Exception e)
            {
                Error(e);
                return;
            }

            arr = new double[a];
            Random rand = new Random();
            Console.WriteLine("Картеж до");
            for (int i = 0; i < a; i++)
            {
                arr[i] = rand.Next(-100,100);
                Console.Write(arr[i] + "\t");

            }
            Console.WriteLine("\nКартеж после");
            for (int i = 0; i < a; i++)
            {
                if (arr[i] < 0)
                    arr[i] = 0;

                Console.Write(arr[i] + "\t");
            }
            

            Console.WriteLine("\n\nНажмите клавишу для продолжения..\n");
            Console.ReadKey();
            Console.Clear();

        }

        static void Case3()
        {
            Console.Clear();
            double[,] arr;
            int a,b;
            double max;
            Console.WriteLine("Нахождение максимального элемента матрицы");
            Console.WriteLine("\nВведите размер массива: ");
            try
            {
                a = int.Parse(Console.ReadLine());
            }

            catch (Exception e)
            {
                Error(e);
                return;
            }

            try
            {
                b = int.Parse(Console.ReadLine());
            }

            catch (Exception e)
            {
                Error(e);
                return;
            }

            arr = new double[a,b];
            Random rand = new Random();
            max = arr[0, 0];
            Console.Write("\nМассив");
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < b; j++)
                {
                    arr[i,j] = rand.Next(-100, 100);
                    Console.Write(arr[i, j] + "\t");
                    if (arr[i, j] > max)
                        max = arr[i, j];
                }
            }

            Console.WriteLine("\nМаксимальный элемент массива = " + max);

            Console.WriteLine("\nНажмите клавишу для продолжения..\n");
            Console.ReadKey();
            Console.Clear();
        }

        static void Main(string[] args)
        {
            int i = 0;
            while (i != 4)
            {
                Console.Clear();
                Console.WriteLine("Выберите пункт меню:");
                Console.WriteLine("1 - Вычисление суммы ряда чисел");
                Console.WriteLine("2 - Замена отрицательных элементов картежа на 0");
                Console.WriteLine("3 - Найти максимальный элемент матрицы");
                Console.WriteLine("4 - Выход");
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
                        Case2();
                        break;
                    case 3:
                        Case3();
                        break;
                    case 4:
                        break;
                }
            }
        }
    }
}

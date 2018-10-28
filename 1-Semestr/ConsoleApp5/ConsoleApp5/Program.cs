using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
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
            Console.WriteLine();
            double n=1, y=1, p=-1, s=0;
            while (Math.Abs(y) > 0.01)
            {
                y = p * ((2 * n + 1) / (n * n * n * (n + 1)));
                s = s + y;
                n = n + 1;
                p = -p;
                Console.WriteLine(s);
            }
            Console.WriteLine("-----------------");
            Console.WriteLine(s);
            Console.WriteLine();
        }

        static void Case2()
        {
            Console.WriteLine();
            double n = 1, y = 1, p = -1, s = 0;
            do
            {
                y = p * ((2 * n + 1) / (n * n * n * (n + 1)));
                s = s + y;
                n = n + 1;
                p = -p;
                Console.WriteLine(s);
            }
            while (Math.Abs(y) > 0.01);
            Console.WriteLine("-----------------");
            Console.WriteLine(s);
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int i = 0;
            while (i != 3)
            {
                Console.WriteLine("Выберите пункт меню:");
                Console.WriteLine("1 - Цикл While");
                Console.WriteLine("2 - Цикл Do-While");
                Console.WriteLine("3 - Выход");
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
                        break;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Double a,b,c,h1,h2,h3,p,m1,m2,m3,Rcc,Scc,Ric,Sic;
            do
            {
                Console.Write("Введите первую сторону ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите вторую сторону ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите третью сторону ");
                c = Convert.ToDouble(Console.ReadLine());

                if ((a + b <= c) || (a + c <= b) || (b + c <= a))
                    Console.WriteLine("Такого треугольника не существует, повторите ввод данных\n");
            }
            while ((a + b <= c) || (a + c <= b) || (b + c <= a));

            p = 0.5 * (a + b + c);
            h1 = ((2 * Math.Sqrt(p * (p - a) * (p - b) * (p - c))) / a);
            h2 = ((2 * Math.Sqrt(p * (p - a) * (p - b) * (p - c))) / b);
            h3 = ((2 * Math.Sqrt(p * (p - a) * (p - b) * (p - c))) / c);

            m1 = (Math.Sqrt(2 * b * b + 2 * c * c - a * a)) / 2;
            m2 = (Math.Sqrt(2 * a * a + 2 * c * c - b * b)) / 2;
            m3 = (Math.Sqrt(2 * b * b + 2 * a * a - c * c)) / 2;

            Rcc = ((a * b * c) / (4 * Math.Sqrt(p * (p - a) * (p - b) * (p - c))));
            Scc = Math.PI * Rcc * Rcc;

            Ric = ((Math.Sqrt(p * (p - a) * (p - b) * (p - c))) / p);
            Sic = Math.PI * Ric * Ric;

            Console.WriteLine("\nВысоты:");
            Console.WriteLine("К стороне a = {0}", Math.Round(h1,2));
            Console.WriteLine("К стороне b = {0}", Math.Round(h2, 2));
            Console.WriteLine("К стороне c = {0}", Math.Round(h3, 2));

            Console.WriteLine("\nМедианы:");
            Console.WriteLine("К стороне a = {0}", Math.Round(m1, 2));
            Console.WriteLine("К стороне b = {0}", Math.Round(m2, 2));
            Console.WriteLine("К стороне c = {0}", Math.Round(m3, 2));

            Console.WriteLine("\nРадиус описанной окружности = {0}", Math.Round(Rcc, 2));
            Console.WriteLine("Площадь круга с этим радиусом = {0}", Math.Round(Scc, 2));

            Console.WriteLine("\nРадиус вписанной окружности = {0}", Math.Round(Ric, 2));
            Console.WriteLine("Площадь круга с этим радиусом = {0}", Math.Round(Sic, 2));

            Console.ReadLine();

        }
    }
}

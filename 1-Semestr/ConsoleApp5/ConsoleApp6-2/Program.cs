using System;
using System.Collections.Generic;
using System.IO;
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

        static bool check(string text)
        {
            bool boo1 = false;
            for (int i = 0; i < text.Length - 1; i++)
            {
                if (text[i] == ',' && text[i+1] == '-')
                    boo1 = true;
            }
            return boo1;
        }

        static void txt(string str)
        {
            Console.WriteLine(str);
            using (StreamWriter sw = new StreamWriter(@"D:\output.txt"))
            {
                sw.Write(str);
            }
        }

        static void Case1()
        {
            string text = "";

            using (StreamReader sr = new StreamReader(@"D:\input.txt"))
            {
                text = sr.ReadToEnd();
            }

            Console.WriteLine("\n" + text);
            bool a = check(text);
            string str1 = "Такая последовательность знаков есть";
            string str2 = "Такой последовательности знаков нет";

            if (a == true)
                txt(str1);
            else
                txt(str2);

            Console.WriteLine("\nНажмите клавишу для продолжения..\n");
            Console.ReadKey();
            Console.Clear();
        }


        static void Main(string[] args)
        {
            int i = 0;
            while (i != 2)
            {
                Console.WriteLine("Выяснить, имеются ли в строке S  такие символы Si  и Si+1, \nчто Si - это запятая, а Si+1  -  тире.\n");
                Console.WriteLine("Выберите пункт меню:");
                Console.WriteLine("1 - Запуск");
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

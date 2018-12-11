using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Menu
    {
        public void Mn()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(30, 10);
            Console.Write("****************");
            Console.SetCursorPosition(31, 11);
            Console.Write("ИГРА ЗАКОНЧЕНА");
            Console.SetCursorPosition(30, 12);
            Console.Write("****************");
            Console.SetCursorPosition(30, 14);
            Console.Write("(Enter) Повторить");
            Console.SetCursorPosition(33, 15);
            Console.Write("(Esc) Выход");
            Console.ForegroundColor = ConsoleColor.White;

            ConsoleKeyInfo cki = new ConsoleKeyInfo();
            while (true)
            {
                if (Console.KeyAvailable == true)
                {
                    cki = Console.ReadKey(true);
                    if (cki.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        break;
                    }
                }
                else if (Console.KeyAvailable == true)
                {
                   cki = Console.ReadKey(true);
                   if (cki.Key == ConsoleKey.Escape)
                   {
                        Environment.Exit(0);
                   }
                    
                }
            }           
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Point
    {
        int x;
        int y;
        char sym;

        public void SetX(int x)
        {
            if (x >= 0)
                this.x = x;
            else
                this.x = 0;
        }
        public void SetY(int y)
        {
            if (y >= 0)
                this.y = y;
            else
                this.y = 0;
        }
        public void SetSym(char symbol)
        {
            sym = symbol;
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point();
            p.SetX(0);
            p.SetY(0);
            p.SetSym('*');
            p.Draw();

            p.SetX(1);
            p.SetY(0);
            p.SetSym('-');
            p.Draw();

            p.SetX(2);
            p.SetY(0);
            p.SetSym('-');
            p.Draw();

            p.SetX(3);
            p.SetY(0);
            p.SetSym('-');
            p.Draw();

            p.SetX(4);
            p.SetY(0);
            p.SetSym('*');
            p.Draw();

            p.SetX(1);
            p.SetY(1);
            p.SetSym('*');
            p.Draw();

            p.SetX(2);
            p.SetY(1);
            p.SetSym(' ');
            p.Draw();

            p.SetX(3);
            p.SetY(1);
            p.SetSym('*');
            p.Draw();

            p.SetX(2);
            p.SetY(2);
            p.SetSym('*');
            p.Draw();

            Console.ReadKey();
        }
    }
}

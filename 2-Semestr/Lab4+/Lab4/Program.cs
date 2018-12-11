using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Point
    {
        int x;
        int y;
        char sym;

        public Point(int x, int y, char sym)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }


    class Figure
    {
        protected List<Point> pList;

        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();                      
            }
        }
    }

    class VerticalLine : Figure
    {
        public VerticalLine(int yUp, int yDown, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = yUp; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
    }

    class HorizontalLine : Figure
    {
        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            pList = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            VerticalLine v1 = new VerticalLine(3, 4, 1, '*');
            v1.Draw();                                                  
            HorizontalLine h1 = new HorizontalLine(1, 10, 2, '*');
            h1.Draw();
            //VerticalLine v1 = new VerticalLine(3, 4, 1, '*');
            //v1.Draw();
            VerticalLine v2 = new VerticalLine(3, 4, 10, '*');
            v2.Draw();
            HorizontalLine h2 = new HorizontalLine(1, 10, 5, '*');
            h2.Draw();

            Console.ReadKey();

        }
    }
}

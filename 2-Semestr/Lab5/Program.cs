using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
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

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public bool IsHit(Point p)
        {
            return p.x == this.x && p.y == this.y;
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

        public bool IsHit(Figure figure)
        {
            foreach (var p in pList)
            {
                if (figure.IsHit(p))
                    return true;
            }
            return false;
        }

        private bool IsHit(Point point)
        {
            foreach (var p in pList)
            {
                if (p.IsHit(point))
                    return true;
            }
            return false;
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

    class Checks
    {
        public void Check(Point x, Point y)
        {
            if ((x.IsHit(y)) == true)
                Console.WriteLine("Точки совпадают");
            else
                Console.WriteLine("Точки не совпадают");
        }

        public void Check(HorizontalLine x, VerticalLine y)
        {
            if (x.IsHit(y) == true)
                Console.WriteLine("Линии пересекаются");
            else
                Console.WriteLine("Линии не пересекаются");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Checks check = new Checks();

            Point p = new Point(62, 2, '*');
            p.Draw();
            Point p2 = new Point(p);
            p2.Draw();

            Console.SetCursorPosition(55, 7);
            check.Check(p, p2);


            Point p3 = new Point(80, 2, '*');
            p3.Draw();
            Point p4 = new Point(85, 4, '*');
            p4.Draw();

            Console.SetCursorPosition(75, 7);
            check.Check(p3, p4);


            HorizontalLine h1 = new HorizontalLine(1, 10, 2, '*');
            h1.Draw();
            VerticalLine v1 = new VerticalLine(1, 5, 12, '*');
            v1.Draw();

            Console.SetCursorPosition(1, 7);
            check.Check(h1, v1);


            HorizontalLine h2 = new HorizontalLine(35, 45, 2, '*');
            h2.Draw();
            VerticalLine v2 = new VerticalLine(1, 5, 40, '*');
            v2.Draw();

            Console.SetCursorPosition(30, 7);
            check.Check(h2, v2);

            Console.ReadKey();
        }
    }
}

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

        public Point()
        {
        }

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

        public void Check()
        {

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



    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point(50, 2, '*');
            Point p2 = new Point(p);
   
            //Point p2 = new Point(50, 2, '*');
            //p2.Draw();

            if ((p.IsHit(p2)) == true)
                Console.WriteLine("\n\n\n\n\t\t\t\t\tТочки совпадают");
            else
                Console.WriteLine("\n\n\n\n\t\t\t\t\tТочки не совпадают");

            p.Draw();
            p2.Draw();

            HorizontalLine h1 = new HorizontalLine(1, 10, 2, '*');
            h1.Draw();
            VerticalLine v1 = new VerticalLine(1, 5, 12, '*');
            v1.Draw();

            if (h1.IsHit(v1) == true)
                Console.WriteLine("\nЛинии пересекаются");
            else
                Console.WriteLine("\nЛинии не пересекаются");


            Console.ReadKey();

        }
    }
}

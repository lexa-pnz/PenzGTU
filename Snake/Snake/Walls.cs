using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {
        List<Figure> wallList;

        public Walls(int mapWidhtm, int mapHeight)
        {
            wallList = new List<Figure>();

            HorizontalLine line1 = new HorizontalLine(0, mapWidhtm-2, 0, '+');
            HorizontalLine line2 = new HorizontalLine(0, mapWidhtm-2, mapHeight-1, '+');
            VerticalLine line3 = new VerticalLine(0, mapHeight-1, 0, '+');
            VerticalLine line4 = new VerticalLine(0, mapHeight-1, mapWidhtm-2, '+');

            wallList.Add(line1);
            wallList.Add(line2);
            wallList.Add(line3);
            wallList.Add(line4);
        }

        internal bool IsHit (Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                    return true;
            }
            return false;
        }

        public void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.Draw();
            }
        }
    }
}

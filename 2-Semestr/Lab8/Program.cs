﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lab8
{

    class Program
    {
        static void Main(string[] args)
        {

            Walls walls = new Walls(80, 25);
            walls.Draw();


            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            Point food = new Point(4, 2, '$');
            food.Draw();
            while (true)
            {
                if (snake.Eat(food))
                {
                    food = new Point(food.x + 2, food.y + 1, '$');
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(100);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }

            Console.ReadLine();
        }
    }
}


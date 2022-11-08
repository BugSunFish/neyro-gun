using Prohect_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Shooter
{
    internal class Program
    {
        public const int Wight = 16*2;
        public const int Hight = 9*2;
        static string[,] zone = new string[Wight, Hight];
        static Thread print = new Thread(Print);
        static Player player = new Player(12,6);
        static List<Shoot> pool = new List<Shoot>() { 
            new Shoot(player._x, player._y), 
            new Shoot(player._x, player._y), 
            new Shoot(player._x, player._y), 
            new Shoot(player._x, player._y), 
            new Shoot(player._x, player._y), 
            new Shoot(player._x, player._y), 
            new Shoot(player._x, player._y),
            new Shoot(player._x, player._y),
            new Shoot(player._x, player._y),
            new Shoot(player._x, player._y),
        };

        static void Direction(int n)
        {
            for (int i = 0; i < pool.Count;)
            {
                if (pool[i].flies == 0)
                {
                    pool[i].flies = n;
                    break;
                } 
                else
                {
                    i++;
                }
            }
        }
        static void Create()
        {
            for (int i = 0; i < zone.GetUpperBound(1) + 1/* y */; i++)
            {
                for (int j = 0; j < zone.GetUpperBound(0) + 1/* x */; j++)
                {
                    if (j == player._x && i == player._y)
                    {
                        zone[j, i] = "@";
                    }
                    else if (j == pool[0]._x && i == pool[0]._y)
                    {
                        zone[j, i] = "*";
                    }
                    else if (j == pool[1]._x && i == pool[1]._y)
                    {
                        zone[j, i] = "*";
                    }
                    else if (j == pool[2]._x && i == pool[2]._y)
                    {
                        zone[j, i] = "*";
                    }
                    else if (j == pool[3]._x && i == pool[3]._y)
                    {
                        zone[j, i] = "*";
                    }
                    else if (j == pool[4]._x && i == pool[4]._y)
                    {
                        zone[j, i] = "*";
                    }
                    else if (j == pool[5]._x && i == pool[5]._y)
                    {
                        zone[j, i] = "*";
                    }
                    else if (j == pool[6]._x && i == pool[6]._y)
                    {
                        zone[j, i] = "*";
                    }
                    else if (j == pool[7]._x && i == pool[7]._y)
                    {
                        zone[j, i] = "*";
                    }
                    else if (j == pool[8]._x && i == pool[8]._y)
                    {
                        zone[j, i] = "*";
                    }
                    else if (j == pool[9]._x && i == pool[9]._y)
                    {
                        zone[j, i] = "*";
                    }
                    else
                    {
                        zone[j, i] = " ";
                    }
                }
            }
        }
        static void Print()
        {
            while (true)
            {
                Thread.Sleep(25);
                for (int i = 0; i < zone.GetUpperBound(1) + 1/* y */; i++)
                {
                    for (int j = 0; j < zone.GetUpperBound(0) + 1/* x */; j++)
                    {
                        if (zone[j, i] != " ") { Console.SetCursorPosition(j, i); Console.Write(" "); }
                    }
                }
                for (int i = 0; i < pool.Count; i++)
                {
                    if (pool[i]._x > Wight || pool[i]._x < 0 || pool[i]._y > Hight || pool[i]._y < 0)
                    {
                        pool[i].flies = 0;
                    }
                    switch (pool[i].flies)
                    {
                        case 0:
                            pool[i]._x = player._x;
                            pool[i]._y = player._y;
                            break;
                        case 1:
                            pool[i]._x++;
                            break;
                        case 2:
                            pool[i]._x--;
                            break;
                        case 3:
                            pool[i]._y++;
                            break;
                        case 4:
                            pool[i]._y--;
                            break;
                    } //Fly pool
                }
                Create();
                Console.SetCursorPosition(0, 0);
                for (int i = 0; i < zone.GetUpperBound(1) + 1/* y */; i++)
                {
                    for (int j = 0; j < zone.GetUpperBound(0) + 1/* x */; j++)
                    {
                        if (zone[j, i] != " ") { Console.SetCursorPosition(j, i); Console.WriteLine(zone[j, i]); }
                    }
                }
                Console.SetCursorPosition(0, 0);
                Console.WriteLine($"p.{player._x}.{player._y}:s.{pool[0]._x}.{pool[0]._y} "); //Coordinate
            }
        }
        static void Main()
        {
            Console.SetWindowSize(Wight, Hight);
            Console.CursorVisible = false;
            print.Start();
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.W:
                        player._y--;
                        break;
                    case ConsoleKey.S:
                        player._y++;
                        break;
                    case ConsoleKey.A:
                        player._x--;
                        break;
                    case ConsoleKey.D:
                        player._x++;
                        break;
                    case ConsoleKey.RightArrow:
                        Direction(1);
                        break;
                    case ConsoleKey.LeftArrow:
                        Direction(2);
                        break;
                    case ConsoleKey.DownArrow:
                        Direction(3);
                        break;
                    case ConsoleKey.UpArrow:
                        Direction(4);
                        break;
                }
            }
        }
    }
}

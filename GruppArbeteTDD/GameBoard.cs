using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppArbeteTDD
{
    public class GameBoard
    {
        public int[,] gameBoard;
        Random rnd = new Random();
        TimeSpan now;
        TimeSpan start;
        TimeSpan end;

        public GameBoard()
        {
            CreateGameBoard();
        }

        private void CreateGameBoard()
        {
            gameBoard = new int[,]
            {                              {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
                                           {1, 2, 0, 1, 0, 0, 0, 0, 0, 0, 0, 3, 1, 0, 0, 0, 0, 0, 0, 0, 1, 3, 0, 0, 1 },
                                           {1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1 },
                                           {1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1 },
                                           {1, 0, 0, 1, 3, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 1 },
                                           {1, 0, 0, 1, 1, 1, 1, 1, 1, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 1 },
                                           {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 1 },
                                           {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 1 },
                                           {1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 3, 0, 1, 0, 0, 1, 0, 0, 0, 1 },
                                           {1, 0, 0, 0, 0, 0, 1, 0, 5, 5, 5, 5, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1 },
                                           {1, 3, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0, 0, 0, 0, 1 },
                                           {1, 0, 0, 0, 0, 0, 1, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0, 0, 0, 0, 1 },
                                           {1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 1, 1, 1, 0, 0, 1 },
                                           {1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 1, 0, 0, 0, 0, 1 },
                                           {1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 1, 0, 0, 0, 0, 1 },
                                           {1, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 1, 0, 0, 0, 0, 1 },
                                           {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 1, 0, 0, 3, 1, 0, 0, 0, 0, 1 },
                                           {1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 1 },
                                           {1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 1 },
                                           {1, 0, 0, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 1 },
                                           {1, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1 },
                                           {1, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1 },
                                           {1, 0, 0, 1, 0, 0, 0, 0, 3, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1 },
                                           {1, 0, 3, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1 },
                                           {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }
            };
        }

        public void RevealDoor()
        {
            gameBoard[rnd.Next(1, 24), 23] = 4;
        }

        public bool OnTreasure(Point p)
        {
            if (gameBoard[p.X, p.Y] == 3) return true;
            else return false;
        }

        public bool OnCollision(Point p)
        {
            if (gameBoard[p.X, p.Y] == 1) return false;
            else return true;
        }

        public bool OnLaser(Point p)
        {
            if (gameBoard[p.X, p.Y] == 5 && TimeForLaser()) return true;
            else return false;
        }

        public bool TimeForLaser()
        {
            now = DateTime.Now.TimeOfDay;
            start = new TimeSpan(20, 0, 0);
            end = new TimeSpan(19, 0, 0);
            int presentHours = now.Hours;

            if (presentHours % 2 == 0)
                return true;

            return (now < end || now > start);
        }

        public void PrintGameBoard()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 25; j++)
                {
                    switch (gameBoard[i, j])
                    {
                        case 0:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("  ");
                            break;
                        case 1:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("# ");
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("P ");
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("T ");
                            break;
                        case 4:
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.Write("D ");
                            break;
                        case 5:
                            Console.ForegroundColor = ConsoleColor.Red;
                            if (TimeForLaser())
                                Console.Write("L ");
                            else
                                Console.Write("  ");
                            break;
                    }
                }
            }
        }
    }
}

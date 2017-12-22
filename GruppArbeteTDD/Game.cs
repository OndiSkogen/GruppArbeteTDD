using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppArbeteTDD
{
    class Game
    {
        public void Run()
        {
            GameBoard gb = new GameBoard();
            Point temp = new Point(1, 1);
            Character player = new Character(temp);

            while (true)
            {
                gb.PrintGameBoard();
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                switch (keyInfo.Key)
                {
                    case ConsoleKey.W:
                    case ConsoleKey.UpArrow:
                        player.MoveUp(gb);
                        break;
                    case ConsoleKey.A:
                    case ConsoleKey.LeftArrow:
                        player.MoveLeft(gb);
                        break;
                    case ConsoleKey.S:
                    case ConsoleKey.DownArrow:
                        player.MoveDown(gb);
                        break;
                    case ConsoleKey.D:
                    case ConsoleKey.RightArrow:
                        player.MoveRight(gb);
                        break;
                }
                Console.Clear();
            }
        }
    }
}

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
            gb.CreateGameBoard();
            Point temp = new Point(1, 1);
            Character player = new Character(temp);
            gb.PlayerMove(temp, temp);

            while (true)
            {
                gb.PrintGameBoard();
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                switch (keyInfo.Key)
                {
                    case ConsoleKey.W:
                    case ConsoleKey.UpArrow:
                        temp.X = player.CurrPos.X;
                        temp.Y = player.CurrPos.Y;
                        temp.X--;
                        gb.PlayerMove(player.CurrPos, temp);
                        break;
                    case ConsoleKey.A:
                    case ConsoleKey.LeftArrow:
                        temp.X = player.CurrPos.X;
                        temp.Y = player.CurrPos.Y;
                        temp.Y--;
                        gb.PlayerMove(player.CurrPos, temp);
                        break;
                    case ConsoleKey.S:
                    case ConsoleKey.DownArrow:
                        temp.X = player.CurrPos.X;
                        temp.Y = player.CurrPos.Y;
                        temp.X++;
                        gb.PlayerMove(player.CurrPos, temp);
                        break;
                    case ConsoleKey.D:
                    case ConsoleKey.RightArrow:
                        temp.X = player.CurrPos.X;
                        temp.Y = player.CurrPos.Y;
                        temp.Y++;
                        gb.PlayerMove(player.CurrPos, temp);
                        break;
                }
                Console.Clear();
            }
            
            Console.ReadLine();
        }
        
    }
}

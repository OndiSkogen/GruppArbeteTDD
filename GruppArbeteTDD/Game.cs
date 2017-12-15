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
                        gb.gameBoard[player.GetCharacterX(), player.GetCharacterY()] = 0;
                        player.MoveUp(gb);
                        gb.gameBoard[player.GetCharacterX(), player.GetCharacterY()] = 2;
                        break;
                    case ConsoleKey.A:
                    case ConsoleKey.LeftArrow:
                        gb.gameBoard[player.GetCharacterX(), player.GetCharacterY()] = 0;
                        player.MoveLeft(gb);
                        gb.gameBoard[player.GetCharacterX(), player.GetCharacterY()] = 2;
                        break;
                    case ConsoleKey.S:
                    case ConsoleKey.DownArrow:
                        gb.gameBoard[player.GetCharacterX(), player.GetCharacterY()] = 0;
                        player.MoveDown(gb);
                        gb.gameBoard[player.GetCharacterX(), player.GetCharacterY()] = 2;
                        break;
                    case ConsoleKey.D:
                    case ConsoleKey.RightArrow:
                        gb.gameBoard[player.GetCharacterX(), player.GetCharacterY()] = 0;
                        player.MoveRight(gb);
                        gb.gameBoard[player.GetCharacterX(), player.GetCharacterY()] = 2;
                        break;
                }
                Console.Clear();
            }
            
            Console.ReadLine();
        }
        
    }
}

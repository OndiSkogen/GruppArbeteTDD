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
                        if (gb.OnTreasure(player.CurrPos, gb)) player.AddTreasure(gb);
                        if (gb.gameBoard[player.GetCharacterX(), player.GetCharacterY()] == 4) Environment.Exit(0);
                        gb.gameBoard[player.GetCharacterX(), player.GetCharacterY()] = 2;
                        break;
                    case ConsoleKey.A:
                    case ConsoleKey.LeftArrow:
                        gb.gameBoard[player.GetCharacterX(), player.GetCharacterY()] = 0;
                        player.MoveLeft(gb);
                        if (gb.OnTreasure(player.CurrPos, gb)) player.AddTreasure(gb);
                        if (gb.gameBoard[player.GetCharacterX(), player.GetCharacterY()] == 4) Environment.Exit(0);
                        gb.gameBoard[player.GetCharacterX(), player.GetCharacterY()] = 2;
                        break;
                    case ConsoleKey.S:
                    case ConsoleKey.DownArrow:
                        gb.gameBoard[player.GetCharacterX(), player.GetCharacterY()] = 0;
                        player.MoveDown(gb);
                        if (gb.OnTreasure(player.CurrPos, gb)) player.AddTreasure(gb);
                        if (gb.gameBoard[player.GetCharacterX(), player.GetCharacterY()] == 4) Environment.Exit(0);
                        gb.gameBoard[player.GetCharacterX(), player.GetCharacterY()] = 2;
                        break;
                    case ConsoleKey.D:
                    case ConsoleKey.RightArrow:
                        gb.gameBoard[player.GetCharacterX(), player.GetCharacterY()] = 0;
                        player.MoveRight(gb);
                        if (gb.OnTreasure(player.CurrPos, gb)) player.AddTreasure(gb);
                        if (gb.gameBoard[player.GetCharacterX(), player.GetCharacterY()] == 4) Environment.Exit(0);
                        gb.gameBoard[player.GetCharacterX(), player.GetCharacterY()] = 2;
                        break;
                }
                Console.Clear();
                //Console.WriteLine("You have " + player.GetTreasure() + " treasures!");
                //if (player.GetTreasure() == 10) gb.RevealDoor();
            }
            
            Console.ReadLine();
        }
        
    }
}

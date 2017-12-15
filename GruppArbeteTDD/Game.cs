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
                        Point tempA = new Point();
                        tempA.X = player.CurrPos.X;
                        tempA.Y = player.CurrPos.Y;
                        tempA.X--;
                        gb.PlayerMove(player.CurrPos, tempA);
                        break;
                    case ConsoleKey.A:
                    case ConsoleKey.LeftArrow:
                        Point tempB = new Point();
                        tempB.X = player.CurrPos.X;
                        tempB.Y = player.CurrPos.Y;
                        tempB.X--;
                        gb.PlayerMove(player.CurrPos, tempB);
                        break;
                    case ConsoleKey.S:
                    case ConsoleKey.DownArrow:
                        Point tempC = new Point();
                        tempC.X = player.CurrPos.X;
                        tempC.Y = player.CurrPos.Y;
                        tempC.X--;
                        gb.PlayerMove(player.CurrPos, tempC);
                        break;
                    case ConsoleKey.D:
                    case ConsoleKey.RightArrow:
                        Point tempD = new Point();
                        tempD.X = player.CurrPos.X;
                        tempD.Y = player.CurrPos.Y;
                        tempD.X--;
                        gb.PlayerMove(player.CurrPos, tempD);
                        break;
                }
                Console.Clear();
            }
            
            Console.ReadLine();
        }
        
    }
}

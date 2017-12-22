using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppArbeteTDD
{
    public class Character
    {
        Point currPos;
        Point prevPos;
        int treasure = 0;

        public Point CurrPos { get => currPos; set => currPos = value; }
        public Point PrevPos { get => prevPos; set => prevPos = value; }
        public int Treasure { get => treasure; set => treasure = value; }

        public Character(Point p)
        {
            currPos = p;
        }

        public void AddTreasure(GameBoard gb)
        {
            treasure++;
            Console.Beep();
            if (treasure == 10) gb.RevealDoor();
        }       
        
        public int GetCharacterX()
        {
            return currPos.X;
        }

        public int GetCharacterY()
        {
            return currPos.Y;
        }

        public void MoveDown(GameBoard gb)
        {
            gb.gameBoard[GetCharacterX(), GetCharacterY()] = 0;
            currPos.X++;
            if (!gb.OnCollision(currPos)) currPos.X--;
            CheckPosition(gb, this);
            gb.gameBoard[GetCharacterX(), GetCharacterY()] = 2;
        }

        public void MoveUp(GameBoard gb)
        {
            gb.gameBoard[GetCharacterX(), GetCharacterY()] = 0;
            currPos.X--;
            if (!gb.OnCollision(currPos)) currPos.X++;
            CheckPosition(gb, this);
            gb.gameBoard[GetCharacterX(), GetCharacterY()] = 2;
        }

        public void MoveRight(GameBoard gb)
        {
            gb.gameBoard[GetCharacterX(), GetCharacterY()] = 0;
            currPos.Y++;
            if (!gb.OnCollision(currPos)) currPos.Y--;
            CheckPosition(gb, this);
            gb.gameBoard[GetCharacterX(), GetCharacterY()] = 2;
        }

        public void MoveLeft(GameBoard gb)
        {

            gb.gameBoard[GetCharacterX(), GetCharacterY()] = 0;
            currPos.Y--;
            if (!gb.OnCollision(currPos)) currPos.Y++;
            CheckPosition(gb, this);
            gb.gameBoard[GetCharacterX(), GetCharacterY()] = 2;
        }

        private void PlayerDied()
        {
            Console.Clear();
            Console.WriteLine("You died!/nPress Enter to exit");
            Console.ReadKey();
            Environment.Exit(0);
        }

        public void CheckPosition(GameBoard gb, Character player)
        {
            if (gb.OnTreasure(player.CurrPos)) player.AddTreasure(gb);
            if (gb.gameBoard[player.GetCharacterX(), player.GetCharacterY()] == 4)
            {
                Console.Clear();
                Console.WriteLine("You won the game!/nPress Enter to exit");
                Console.ReadKey();
                Environment.Exit(0);
            }
            if (gb.OnLaser(player.CurrPos)) PlayerDied();
        }
    }
}

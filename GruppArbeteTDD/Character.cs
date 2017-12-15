using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppArbeteTDD
{
    class Character
    {
        Point currPos;
        Point prevPos;
        int treasure = 0;

        public Point CurrPos { get => currPos; set => currPos = value; }
        public Point PrevPos { get => prevPos; set => prevPos = value; }

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

        public int GetTreasure()
        {
            return treasure;
        }
        
        public void changePos(Point p)
        {
            prevPos = currPos;
            currPos = p;
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
            currPos.X++;
            if (!gb.OnCollision(currPos)) currPos.X--;
        }

        public void MoveUp(GameBoard gb)
        {
            currPos.X--;
            if (!gb.OnCollision(currPos)) currPos.X++;
        }

        public void MoveRight(GameBoard gb)
        {
            currPos.Y++;
            if (!gb.OnCollision(currPos)) currPos.Y--;
        }

        public void MoveLeft(GameBoard gb)
        {
            currPos.Y--;
            if (!gb.OnCollision(currPos)) currPos.Y++;
        }
    }
}

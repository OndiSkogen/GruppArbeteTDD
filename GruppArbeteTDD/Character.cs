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

        public Point CurrPos { get => currPos; set => currPos = value; }
        public Point PrevPos { get => prevPos; set => prevPos = value; }

        public Character(Point p)
        {
            currPos = p;
        }
        
        public void changePos(Point p)
        {
            prevPos = currPos;
            currPos = p;
        }


        public void IncreaseX()
        {
            currPos.X++;
        }

        public void DecreaseX()
        {
            currPos.X--;
        }

        public void IncreaseY()
        {
            currPos.Y++;
        }

        public void DecreaseY()
        {
            currPos.Y--;
        }
    }
}

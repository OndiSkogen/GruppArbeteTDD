using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GruppArbeteTDD;

namespace GruppArbeteTDDTests
{
    [TestClass]
    public class GameBoardTests
    {
        [TestMethod()]
        public void CreateGameBoardTest()
        {
            //Arrange
            GameBoard gb = new GameBoard();

            //Act

            //Assert
            Assert.AreEqual(1, gb.gameBoard[0, 0]);
            Assert.AreEqual(0, gb.gameBoard[1, 2]);
            Assert.AreEqual(2, gb.gameBoard[1, 1]);
            Assert.AreEqual(1, gb.gameBoard[24, 24]);
            Assert.AreEqual(3, gb.gameBoard[1, 11]);
        }

        [TestMethod()]
        public void TestNoOfTreasures()
        {
            //Arrange
            GameBoard gb = new GameBoard();

            //Act
            int actual = 0;
            for (int i = 0; i < 25; i++)
            {
                for (int j = 0; j < 25; j++)
                {
                    if (gb.gameBoard[i, j] == 3) actual++;
                }
            }

            //Assert
            Assert.AreEqual(10, actual);
        }

        [TestMethod]
        public void OnTreasureTest()
        {
            //Arr
            GameBoard gb = new GameBoard();
            Point p = new Point(1, 11);
            
            //Act
            bool actual = gb.OnTreasure(p);
            //Ass
            
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void AddTreasureTest()
        {
            //Arrange
            GameBoard gb = new GameBoard();
            Point p = new Point(1, 1);
            Character player = new Character(p);

            //Act
            player.AddTreasure(gb);
            player.AddTreasure(gb);
            player.AddTreasure(gb);

            //Assert
            Assert.AreEqual(3, player.Treasure);
        }

        [TestMethod()]
        public void MovementTest()
        {
            //Arrange
            GameBoard gb = new GameBoard();
            Point p = new Point(1, 1);
            Character player = new Character(p);

            //Act
            player.MoveRight(gb);
            player.MoveDown(gb);
            player.MoveDown(gb);
            player.MoveLeft(gb);
            player.MoveUp(gb);

            //Assert
            Assert.AreEqual(1, player.CurrPos.Y);
            Assert.AreEqual(2, player.CurrPos.X);
        }

        [TestMethod()]
        public void WallCollisionTest()
        {
            //Arrange
            GameBoard gb = new GameBoard();
            Point p = new Point(1, 1);
            Character player = new Character(p);

            //Act
            player.MoveLeft(gb);
            player.MoveUp(gb);

            //Assert
            Assert.AreEqual(1, player.CurrPos.Y);
            Assert.AreEqual(1, player.CurrPos.X);
        }

        [TestMethod()]
        public void VisibleDoorTest()
        {
            //Arrange
            GameBoard gb = new GameBoard();
            bool doorVisible = false;
            Point p = new Point(1, 1);
            Character player = new Character(p);

            //Act
            player.Treasure = 9;
            player.AddTreasure(gb);
            for (int i = 0; i < 25; i++)
            {
                for (int j = 0; j < 25; j++)
                {
                    if (gb.gameBoard[i, j] == 4) doorVisible = true;
                }
            }

            //Assert
            Assert.IsTrue(doorVisible);
        }
    }
}

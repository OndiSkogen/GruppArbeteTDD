using Microsoft.VisualStudio.TestTools.UnitTesting;
using GruppArbeteTDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppArbeteTDD.Tests
{
    [TestClass()]
    public class GameBoardTests
    {
        [TestMethod()]
        public void CreateGameBoardTest()
        {
            //Arrange
            GameBoard gb = new GameBoard();

            //Act
            gb.CreateGameBoard();

            //Assert
            Assert.AreEqual(1, gb.gameBoard[0, 0]);
            Assert.AreEqual(0, gb.gameBoard[1, 1]);
        }

        [TestMethod()]
        public void TestNoOfTreasures()
        {
            //Arrange
            GameBoard gb = new GameBoard();

            //Act
            gb.CreateGameBoard();
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
    }
}
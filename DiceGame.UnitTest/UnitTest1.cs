using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DiceGame.UnitTest
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void RollDiceTest()
        {
            //Arrange
            int dieRollOne = 2;
            int dieRollTwo = 5;
            //Act
            int dieSum = dieRollOne + dieRollTwo;
            //Assert
            Assert.AreEqual (7, dieSum);
        }
    }
}

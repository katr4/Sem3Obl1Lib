using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sem3Obl1Lib;

namespace LibTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFootballPlayerCreation()
        {
            // Arrange
            FootballPlayer testPlayer = new FootballPlayer(1, "Michelle", 250, 40);
            List<FootballPlayer> testList = new List<FootballPlayer>();
            int playerCountBefore = testList.Count;

            // Act
            testList.Add(testPlayer);
            int playerCountAfter = testList.Count;

            // Assert
            Assert.AreNotEqual(playerCountBefore, playerCountAfter);
        }

        [TestMethod]
        public void TestFootballIdGet()
        {
            // Arrange
            FootballPlayer testPlayer = new FootballPlayer(1, "Michelle", 250, 40);
            int actualPlayerId = 1;

            // Act
            int getPlayerId = testPlayer.Id;

            // Assert
            Assert.AreEqual(actualPlayerId, getPlayerId);
        }
        [TestMethod]
        public void TestFootballNameGet()
        {
            // Arrange
            FootballPlayer testPlayer = new FootballPlayer(1, "Michelle", 250, 40);
            string actualPlayerName = "Michelle";

            // Act
            string getPlayerName = testPlayer.Name;

            // Assert
            Assert.AreEqual(actualPlayerName, getPlayerName);
        }
        [TestMethod]
        public void TestFootballPriceGet()
        {
            // Arrange
            FootballPlayer testPlayer = new FootballPlayer(1, "Michelle", 250, 40);
            int actualPlayerPrice = 250;

            // Act
            int getPlayerPrice = testPlayer.Price;

            // Assert
            Assert.AreEqual(actualPlayerPrice, getPlayerPrice);
        }
        [TestMethod]
        public void TestFootballShirtnumberGet()
        {
            // Arrange
            FootballPlayer testPlayer = new FootballPlayer(1, "Michelle", 250, 40);
            int actualPlayerShirtnumber = 40;

            // Act
            int getPlayerShirtnumber = testPlayer.ShirtNumber;

            // Assert
            Assert.AreEqual(actualPlayerShirtnumber, getPlayerShirtnumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestFootballPlayerNameNull()
        {
            // Arrange
            FootballPlayer testPlayer = new FootballPlayer(1, "", 10000, 4);

            // Act

            // Assert

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestFootballPlayerNameUnderLimit()
        {
            // Arrange
            FootballPlayer testPlayer = new FootballPlayer(1, "Nik", 10000, 4);

            // Act

            // Assert
            
        }
        [TestMethod]
        public void TestFootballPlayerNameOnLimit()
        {
            // Arrange
            FootballPlayer testPlayer = new FootballPlayer(1, "Niko", 10000, 4);

            // Act

            // Assert

        }
        [TestMethod]
        public void TestFootballPlayerNameOver()
        {
            // Arrange
            FootballPlayer testPlayer = new FootballPlayer(1, "Nikos", 10000, 4);

            // Act

            // Assert

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestFootballPlayerPriceUnderLimit()
        {
            // Arrange
            FootballPlayer testPlayer = new FootballPlayer(1, "Michelle", 0, 4);

            // Act

            // Assert

        }
        [TestMethod]
        public void TestFootballPlayerPriceOnLimit()
        {
            // Arrange
            FootballPlayer testPlayer = new FootballPlayer(1, "Michelle", 1, 4);

            // Act

            // Assert

        }
        [TestMethod]
        public void TestFootballPlayerPriceOver()
        {
            // Arrange
            FootballPlayer testPlayer = new FootballPlayer(1, "Michelle", 2, 4);

            // Act

            // Assert

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestFootballPlayerShirtUnderLimit()
        {
            // Arrange
            FootballPlayer testPlayer = new FootballPlayer(1, "Michelle", 250, 0);

            // Act

            // Assert

        }
        [TestMethod]
        public void TestFootballPlayerShirtSmallOnLimit()
        {
            // Arrange
            FootballPlayer testPlayer = new FootballPlayer(1, "Michelle", 250, 1);

            // Act

            // Assert

        }
        [TestMethod]
        public void TestFootballPlayerShirtOver()
        {
            // Arrange
            FootballPlayer testPlayer = new FootballPlayer(1, "Michelle", 250, 2);

            // Act

            // Assert

        }
        [TestMethod]
        public void TestFootballPlayerShirtUnder()
        {
            // Arrange
            FootballPlayer testPlayer = new FootballPlayer(1, "Michelle", 250, 99);

            // Act

            // Assert

        }
        [TestMethod]
        public void TestFootballPlayerShirtBigOnLimit()
        {
            // Arrange
            FootballPlayer testPlayer = new FootballPlayer(1, "Michelle", 250, 100);

            // Act

            // Assert

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestFootballPlayerShirtOverLimit()
        {
            // Arrange
            FootballPlayer testPlayer = new FootballPlayer(1, "Michelle", 250, 101);

            // Act

            // Assert

        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Tests
{
    [TestClass()]
    public class RockPaperScissorsTests
    {
        private RockPaperScissors _rockPaperScissors = new();

        // Normal Cases
        [DataTestMethod]
        [DataRow("Rock", "Rock", "Tie")]
        [DataRow("Paper", "Paper", "Tie")]
        [DataRow("Scissors", "Scissors", "Tie")]
        [DataRow("Rock", "Scissors", "Winner")]
        [DataRow("Paper", "Rock", "Winner")]
        [DataRow("Scissors", "Paper", "Winner")]
        [DataRow("Rock", "Paper", "Loser")]
        [DataRow("Paper", "Scissors", "Loser")]
        [DataRow("Scissors", "Rock", "Loser")]
        public void GetResult_ValidChoices_ReturnsExpected(
            string playerOneChoice,
            string playerTwoChoice,
            string expected)
        {
            // Act
            var result = _rockPaperScissors.GetResult(playerOneChoice, playerTwoChoice);

            // Assert
            Assert.AreEqual(expected, result);
        }

        // Null inputs
        [TestMethod]
        public void GetResult_NullFirstChoice_ThrowsArgumentNullException()
        {
            Assert.ThrowsException<ArgumentNullException>(
                () => _rockPaperScissors.GetResult(null, "Rock"));
        }

        [TestMethod]
        public void GetResult_NullSecondChoice_ThrowsArgumentNullException()
        {
            Assert.ThrowsException<ArgumentNullException>(
                () => _rockPaperScissors.GetResult("Rock", null));
        }

        // Empty‐string inputs
        [TestMethod]
        public void GetResult_EmptyStringFirstChoice_ThrowsArgumentNullException()
        {
            Assert.ThrowsException<ArgumentNullException>(
                () => _rockPaperScissors.GetResult("", "Rock"));
        }
        [TestMethod]
        public void GetResult_EmptyStringSecondChoice_ThrowsArgumentNullException()
        {
            Assert.ThrowsException<ArgumentNullException>(
                () => _rockPaperScissors.GetResult("Rock", ""));
        }
    }
}
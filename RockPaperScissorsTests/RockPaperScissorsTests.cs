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
    [TestClass]
    public class GameTests
    {
        private RockPaperScissors _rockPaperScissors = new();

        // --- All valid combinations: Tie, Winner, Loser ---
        [DataTestMethod]
        [DataRow("Rock", "Rock", "Tie")]
        [DataRow("Paper", "Paper", "Tie")]
        [DataRow("Scissors", "Scissors", "Tie")]
        [DataRow("Lizard", "Lizard", "Tie")]
        [DataRow("Spock", "Spock", "Tie")]

        [DataRow("Rock", "Scissors", "Winner")]
        [DataRow("Rock", "Lizard", "Winner")]
        [DataRow("Paper", "Rock", "Winner")]
        [DataRow("Paper", "Spock", "Winner")]
        [DataRow("Scissors", "Paper", "Winner")]
        [DataRow("Scissors", "Lizard", "Winner")]
        [DataRow("Lizard", "Spock", "Winner")]
        [DataRow("Lizard", "Paper", "Winner")]
        [DataRow("Spock", "Scissors", "Winner")]
        [DataRow("Spock", "Rock", "Winner")]

        [DataRow("Scissors", "Rock", "Loser")]
        [DataRow("Lizard", "Rock", "Loser")]
        [DataRow("Rock", "Paper", "Loser")]
        [DataRow("Spock", "Paper", "Loser")]
        [DataRow("Paper", "Scissors", "Loser")]
        [DataRow("Lizard", "Scissors", "Loser")]
        [DataRow("Spock", "Lizard", "Loser")]
        [DataRow("Paper", "Lizard", "Loser")]
        [DataRow("Scissors", "Spock", "Loser")]
        [DataRow("Rock", "Spock", "Loser")]
        public void GetResultSpock_ValidChoices_ReturnsExpected(
            string playerOneChoice,
            string playerTwoChoice,
            string expected)
        {
            // Act
            var result = _rockPaperScissors.GetResultSpock(playerOneChoice, playerTwoChoice);

            // Assert
            Assert.AreEqual(expected, result);
        }

        // --- Null / empty inputs throw ArgumentNullException ---
        [TestMethod]
        public void GetResultSpock_NullFirstChoice_ThrowsArgumentNullException()
            => Assert.ThrowsException<ArgumentNullException>(
                   () => _rockPaperScissors.GetResultSpock(null, "Rock"));

        [TestMethod]
        public void GetResultSpock_NullSecondChoice_ThrowsArgumentNullException()
            => Assert.ThrowsException<ArgumentNullException>(
                   () => _rockPaperScissors.GetResultSpock("Rock", null));

        [TestMethod]
        public void GetResultSpock_EmptyFirstChoice_ThrowsArgumentNullException()
            => Assert.ThrowsException<ArgumentNullException>(
                   () => _rockPaperScissors.GetResultSpock(string.Empty, "Rock"));

        [TestMethod]
        public void GetResultSpock_EmptySecondChoice_ThrowsArgumentNullException()
            => Assert.ThrowsException<ArgumentNullException>(
                   () => _rockPaperScissors.GetResultSpock("Rock", string.Empty));
    }
}
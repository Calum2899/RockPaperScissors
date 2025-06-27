using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class RockPaperScissors
    {
        public string computer { private set; get; } = string.Empty;
        public string player = string.Empty;
        public string playerLastChoice = string.Empty;


        public string result { private set; get; } = string.Empty;
        private string[] choices = { "Rock", "Paper", "Scissors" };

        public void PlayNormal(string playerChoice)
        {
            computer = choices[new Random().Next(choices.Length)];
            result = GetResult(playerChoice, computer);
        }
        public void PlayLastChoiceComputer(string playerChoice)
        {
            
            if (computer == string.Empty)
                computer = choices[new Random().Next(choices.Length)];
            else
            {
                computer = playerLastChoice;
            }
                result = GetResult(playerChoice, computer);
            
        }
        public void PlaySpock(string playerChoice)
        {
            computer = choices[new Random().Next(choices.Length)];
            result = GetResultSpock(playerChoice, computer);
        }
        public string GetResult(string playerOneChoice, string playerTwoChoice)// player two assume is computer so only gives result for player one
        {
            if (string.IsNullOrEmpty(playerOneChoice))
                throw new ArgumentNullException(nameof(playerOneChoice), "Player one's choice cannot be null or empty.");
            if (string.IsNullOrEmpty(playerTwoChoice))
                throw new ArgumentNullException(nameof(playerTwoChoice), "Player two's choice cannot be null or empty.");
            playerLastChoice = playerOneChoice;
            if (playerOneChoice == playerTwoChoice)
                return "Tie";
            else if ((playerOneChoice == "Rock" && playerTwoChoice == "Scissors") ||
                     (playerOneChoice == "Paper" && playerTwoChoice == "Rock") ||
                     (playerOneChoice == "Scissors" && playerTwoChoice == "Paper"))
                return "Winner";
            else
                return "Loser";
        }

        public string GetResultSpock(string playerOneChoice, string playerTwoChoice)// player two assume is computer so only gives result for player one
        {
            if (string.IsNullOrEmpty(playerOneChoice))
                throw new ArgumentNullException(nameof(playerOneChoice), "Player one's choice cannot be null or empty.");
            if (string.IsNullOrEmpty(playerTwoChoice))
                throw new ArgumentNullException(nameof(playerTwoChoice), "Player two's choice cannot be null or empty.");
            playerLastChoice = playerOneChoice;
            if (playerOneChoice == playerTwoChoice)
                return "Tie";
            else if ((playerOneChoice == "Rock" && playerTwoChoice == "Scissors") ||
                     (playerOneChoice == "Paper" && playerTwoChoice == "Rock") ||
                     (playerOneChoice == "Scissors" && playerTwoChoice == "Paper")||
                     (playerOneChoice == "Rock" && playerTwoChoice == "Lizard")||
                     (playerOneChoice == "Lizard" && playerTwoChoice == "Spock")||
                     (playerOneChoice == "Lizard" && playerTwoChoice == "Paper")||
                     (playerOneChoice == "Paper" && playerTwoChoice == "Spock")||
                     (playerOneChoice == "Spock" && playerTwoChoice == "Scissors") ||
                     (playerOneChoice == "Scissors" && playerTwoChoice == "Lizard") ||
                     (playerOneChoice == "Spock" && playerTwoChoice == "Rock"))
                return "Winner";
            else
                return "Loser";
        }
    }
}

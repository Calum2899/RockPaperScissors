namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Rock, Paper, Scissors!");
            Console.WriteLine("Enter 0 at any time to come back to this screen or to exit from this screen");
            Console.WriteLine("Choose Gamemode: [1]Normal [2]Last Choice Computer [3]Spock!");
            var gameMode = Console.ReadLine();
            switch (gameMode)
            {
                case "0":
                    Environment.Exit(0);
                    break;
                case "1":
                    var normalGame = new RockPaperScissors();
                    PlayNormal(normalGame);
                    break;
                case "2":
                    var playLastChoiceGame = new RockPaperScissors();
                    PlayLastChoiceComputer(playLastChoiceGame);
                    break;
                case "3":
                    var playSpock = new RockPaperScissors();
                    PlaySpock(playSpock);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select 1, 2, 3. (0 to exit)");
                    Main(new string[] { });
                    break;
            }
        }

        private static void PlayNormal(RockPaperScissors game)
        {
            Console.WriteLine("Select: [1]Rock [2]Paper [3]Scissors");

            var userSelection = Console.ReadLine();
            var playerChoice = string.Empty;
            try
            {
                playerChoice = userSelection switch
                {
                    "0" => "Back",
                    "1" => "Rock",
                    "2" => "Paper",
                    "3" => "Scissors",
                    _ => throw new ArgumentException("Invalid choice. Please select 1, 2, or 3.")
                };
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Please select valid option by entering the desired number");
                PlayNormal(game);
            }
            if (playerChoice == "Back")
                Main(new string[] { });
            game.PlayNormal(playerChoice);
            // Display the result
            Console.WriteLine($"Player choice: {playerChoice}");
            Console.WriteLine($"Computer choice: {game.computer}");
            Console.WriteLine($"Result: {game.result}");

            PlayNormal(game);
        }

        private static void PlayLastChoiceComputer(RockPaperScissors game)
        {
            Console.WriteLine("Select: [1]Rock [2]Paper [3]Scissors");

            var userSelection = Console.ReadLine();
            var playerChoice = string.Empty;
            try
            {
                playerChoice = userSelection switch
                {
                    "0" => "Back",
                    "1" => "Rock",
                    "2" => "Paper",
                    "3" => "Scissors",
                    _ => throw new ArgumentException("Invalid choice. Please select 1, 2, or 3.")
                };
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Please select valid option by entering the desired number");
                PlayLastChoiceComputer(game);
            }
            if (playerChoice == "Back")
                Main(new string[] { });
            game.PlayLastChoiceComputer(playerChoice);
            // Display the result
            Console.WriteLine($"Player choice: {playerChoice}");
            Console.WriteLine($"Computer choice: {game.computer}");
            Console.WriteLine($"Result: {game.result}");

            PlayLastChoiceComputer(game);
        }
        private static void PlaySpock(RockPaperScissors game)
        {
            Console.WriteLine("Select: [1]Rock [2]Paper [3]Scissors [4]Spock [5]Lizard");

            var userSelection = Console.ReadLine();
            var playerChoice = string.Empty;
            try
            {
                playerChoice = userSelection switch
                {
                    "0" => "Back",
                    "1" => "Rock",
                    "2" => "Paper",
                    "3" => "Scissors",
                    "4" => "Spock",
                    "5" => "Lizard",
                    _ => throw new ArgumentException("Invalid choice. Please select 1, 2, 3, 4 or 5.")
                };
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Please select valid option by entering the desired number");
                PlaySpock(game);
            }
            if (playerChoice == "Back")
                Main(new string[] { });
            game.PlaySpock(playerChoice);
            // Display the result
            Console.WriteLine($"Player choice: {playerChoice}");
            Console.WriteLine($"Computer choice: {game.computer}");
            Console.WriteLine($"Result: {game.result}");

            PlaySpock(game);
        }
    }
}




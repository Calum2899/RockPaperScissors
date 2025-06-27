namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {


            RockPaperScissors game = new RockPaperScissors();
            Console.WriteLine("Select [1]Rock [2]Paper [3]Scissors");

            var userSelection = Console.ReadLine();
            var playerChoice = string.Empty;
            try
            {
                playerChoice = userSelection switch
                {
                    "1" => "Rock",
                    "2" => "Paper",
                    "3" => "Scissors",
                    _ => throw new ArgumentException("Invalid choice. Please select 1, 2, or 3.")
                };
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Please select valid option by entering the desired number");
                Main(args);
            }

            game.Play(playerChoice);
            // Display the result
            Console.WriteLine($"Player choice: {playerChoice}");
            Console.WriteLine($"Computer choice: {game.computer}");
            Console.WriteLine($"Result: {game.result}");

            Main(args);
        }
    }
}




using System;
using App;

namespace HowMuch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define the initial config of the game
            GameConfig config = new GameConfig()
            {
                MaxValue = 200
            };
            GameLogic logic = new GameLogic();

            //Set the config on the run (players names and target value)
            config = logic.InitializeGameSettings(config);
            
            //Loop of the game logic : Will keep asking the player to enter a new value until meeting the target
            int nbAttempts = logic.EnterGameLoop(config);
            
            //Prompts the "guesser" with it's number of attempts to find the target
            Console.WriteLine($"Félicitations {config.PlayerName} : Tu as trouvé le juste prix en {nbAttempts} tentatives");

            //Waiting on "Enter" to exit the game
            Console.ReadLine();

            // ** End of the game **
        }
    }
}

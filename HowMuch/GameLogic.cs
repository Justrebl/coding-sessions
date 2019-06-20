using System;
using HMI;

namespace App
{
    class GameLogic
    {
        public GameConfig InitializeGameSettings(GameConfig initialConfig)
        {
            initialConfig = askForPlayerName(initialConfig);
            initialConfig = setRandomTargetValue(initialConfig);

            return initialConfig;
        }

        public int EnterGameLoop(GameConfig config)
        {
            int nbTries = 1; //Number of attemps to find the expected target
            int currentGuess = -1;
            do
            {
                
            } while(currentGuess != config.TargetValue);

            return nbTries;
        }

        private bool isTargetMet (int currentValue, int targetValue)
        {
            
        }

        private GameConfig setRandomTargetValue(GameConfig config)
        {
            Random randomizer = new Random();
            config.TargetValue = randomizer.Next(0, config.MaxValue);
            return config;
        }

        //
        private GameConfig askForPlayerName(GameConfig config)
        {
            Console.WriteLine("Quel est ton nom ?");
            config.PlayerName = Console.ReadLine();
            return config;
        }
    }    
}
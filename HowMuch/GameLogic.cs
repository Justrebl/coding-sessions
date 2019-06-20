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
            int nbTries = 0; //Number of attemps to find the expected target
            int currentGuess = -1; //Current guess from player
            do
            {
                nbTries ++;
                Console.Write($"Tentative Numéro {nbTries} : (Max:{config.MaxValue})");
                currentGuess = PromptsHelpers.GetPositiveNumberFromString(Console.ReadLine());
            }while(!isTargetMet(currentGuess, config.TargetValue));

            return nbTries;
        }

        private bool isTargetMet (int currentValue, int targetValue)
        {
            if (currentValue > targetValue) 
            {
                Console.WriteLine("Moins");
                return false;
            }
            else if(currentValue < targetValue)
            {
                Console.WriteLine("Plus");
                return false;
            }
            else return true;
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
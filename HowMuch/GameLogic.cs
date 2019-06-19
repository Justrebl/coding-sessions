using System;

namespace App
{
    class GameLogic
    {
        public GameConfig Config = new GameConfig(){MaxValue = 200};

        public void InitializeGameSettings(int maxValue, bool randomRequired)
        {
            askForPlayersNames();
            if(randomRequired)
                randomizeTarget(maxValue);
            else
                askForTargetToUser(maxValue);
        }

        private void randomizeTarget(int maxValue)
        {
            Random randomizer = new Random();
            Config.TargetValue = randomizer.Next(0, maxValue);
        }

        private void askForPlayersNames()
        {
            Console.WriteLine("Quel est le nom du premier joueur ?");
            Config.FirstPlayerName = Console.ReadLine();
            Console.WriteLine($"Très bien, le joueur 1 s'appelle donc {Config.FirstPlayerName}.\n"+
            "Comment s'appelle le second joueur ?");
            Config.SecondPlayerName = Console.ReadLine ();
            Console.WriteLine($"Très bien, le joueur 2 s'appelle donc {Config.SecondPlayerName}\n"+
        }

        private void askForTargetToUser(int maxValue)
        {
            int number
            // do
            // {

                Console.WriteLine($"{playerOneName} : Entre un nombre que {playerTwoName} devra trouver :");
                Console.ReadLine();
            // } while(targetNumber < 0);
        }
    }    
}
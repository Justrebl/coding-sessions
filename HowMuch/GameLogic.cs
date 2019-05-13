using System;

namespace App
{
    class GameLogic
    {
        private int targetNumber = -1;
        private string playerOneName = "";
        private string playerTwoName = "";

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
            targetNumber = randomizer.Next(0, maxValue);
        }

        private void askForPlayersNames()
        {
            Console.WriteLine("Quel nom donner au Joueur 1 ?");
            playerOneName = Console.ReadLine();
            Console.WriteLine("Quel nom donner au Joueur 2 ?");
            playerTwoName = Console.ReadLine();
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
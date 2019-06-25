using System;
using HMI;

namespace HowMuch
{
    class Program
    {
        static void Main(string[] args)
        {
            int targetValue = 50; //Value player has to find
            int nbTries = 0; //Number of attemps to find the expected target
            int currentGuess = -1; //Current guess from player

            var helper = new PromptsHelpers(); //Helpers library adding

            while(currentGuess != targetValue)
            {
                nbTries ++;
                Console.Write("Tentative Numéro "+ nbTries +" : ");
                currentGuess = helper.GetPositiveNumberFromString(Console.ReadLine());

                    if (currentGuess > targetValue)
                    {
                        Console.WriteLine("Essayes encore : Moins");
                    }
                    else if(currentGuess < targetValue)
                    {
                        Console.WriteLine("Essayes encore : Plus");
                    }
            }
            
            //Prompts the "guesser" with it's number of attempts to find the target
            Console.WriteLine($"Félicitations ! Tu as trouvé le juste prix "+targetValue+" en "+nbTries+" tentatives !");
            Console.WriteLine($"Penses-tu pouvoir mieux faire la prochaine fois ? ;)");

            //Waiting on "Enter" to exit the game
            Console.ReadLine();

            // ** End of the game **
        }
    }
}

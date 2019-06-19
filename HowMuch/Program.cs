using System;
using App;

namespace HowMuch
{
    class Program
    {
        static void Main(string[] args)
        {
            GameConfig config = new GameConfig(){MaxValue = 200};
            GameLogic logic = new GameLogic();

            logic.askForPlayersNames();
            $"{config.FirstPlayerName} : Quelle sera la valeur (entre 0 et {config.MaxValue}) à trouver ?");


        }
    }
}

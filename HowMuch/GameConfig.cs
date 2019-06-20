using System;

namespace App
{
    struct GameConfig
    {
        public int TargetValue {get; set;} // Value that the guesser will have to find
        public int MaxValue {get; set;} // Maximum value for the target
        public string PlayerName {get; set;} // The name of the player that has to find the target with the minimum attempts 
    }
}


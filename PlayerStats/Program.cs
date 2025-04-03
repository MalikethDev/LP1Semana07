using System;

namespace PlayerStats
{
    public class Player
    {
        private float highScore; // Stores the high score
        private int playedGames; // Number of games played
        private int wonGames; // Number of games won

        // Auto-implemented readonly property for player name
        public string Name { get; }

        // Win rate property (calculated as a percentage)
        public float WinRate => playedGames == 0 ? 0 : (float)wonGames / playedGames;

        // Constructor that accepts the player's name and initializes the stats everything to 0
        public Player(string name)
        {
            Name = name; // Set the player's name
            highScore = 0; // Initialize high score to 0
            playedGames = 0; // Initialize number of games played to 0
            wonGames = 0; // Initialize number of games won to 0
        }

        // High score property (updates only if the new score is higher)
        public float HighScore
        {
            get => highScore;
            set
            {
                if (value > highScore)
                {
                    highScore = value;
                }
            }
        }

        // Method to record a game played (without a score)
        public void PlayGame(bool win)
        {
            playedGames++; // Increment the number of games played
            if (win)
            {
                wonGames++; // Increment the number of games won
            }
        }
    }
}

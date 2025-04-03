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
    }
}

using System;

namespace PlayerStats
{
    public class Player
    {
        private float highScore; // Stores the high score
        private int playedGames; // Number of games played
        private int wonGames; // Number of games won

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

using System;

namespace MyRPG
{
    public class Program
    {
        private static void Main()
        {
            Player player = new Player("Hero");

            Console.WriteLine($"Name: {player.Name}");      // Name: Hero
            Console.WriteLine($"Level: {player.Level}");    // Level: 1
            Console.WriteLine($"XP: {player.XP}");          // XP: 0
            Console.WriteLine($"Health: {player.Health}/{player.MaxHealth}"); // Health: 100/100

            player.XP = 2500; // Aumenta XP para 2500
            Console.WriteLine($"Level: {player.Level}");    // Level: 3
            Console.WriteLine($"XP: {player.XP}");          // XP: 2500
            Console.WriteLine($"MaxHealth: {player.MaxHealth}"); // MaxHealth: 140

            player.TakeDamage(45);
            Console.WriteLine($"Health: {player.Health}/{player.MaxHealth}"); // Health: 55/140
            Console.WriteLine($"XP: {player.XP}");          // XP: 2502
            Console.WriteLine($"Level: {player.Level}");    // Level: 3

            player.Health = -10;  // Tentativa de colocar health negativa
            Console.WriteLine($"Health: {player.Health}");  // Health: 0

            player.Health = 5000; // Tentativa de ultrapassar maxHealth
            Console.WriteLine($"Health: {player.Health}/{player.MaxHealth}"); // Health: 140/140

            // Output esperado:
            //
            // Name: Hero
            // Level: 1
            // XP: 0
            // Health: 100/100
            // Level: 3
            // XP: 2500
            // MaxHealth: 140
            // Health: 55/140
            // XP: 2502
            // Level: 3
            // Health: 0
            // Health: 140/140
    }
}
    public class Player
    {
        private int xp; // Stores the experience points
        private float health; // Stores the health points
        public string Name { get; } // Auto-implemented readonly property for player name

        // XP property (only updates, never decreases)
        public int XP
        {
            get => xp;
            set
            {
                if (value > xp)
                {
                    xp = value; // Update XP only if the new value is higher
                }
            }
        }

        // Auto-implemented readonly property for Level (int)
        public int Level => 1 + xp / 1000; // Returns current level -> 1 + XP / 1000

        // Health property
        // Assures value is between 0 and MaxHealth
        public float Health
        {
            get => health;
            set
            {
                if (value < 0)
                {
                    health = 0; // Set to 0 if less than 0
                }
                else if (value > MaxHealth)
                {
                    health = MaxHealth; // Set to MaxHealth if greater than MaxHealth
                }
                else
                {
                    health = value; // Otherwise, set to the new value
                }
            }
        }
        // MaxHealth auto-implemented readonly property (float)
        public float MaxHealth => 100 + (Level - 1) * 20; // Returns MaxHealth based on level

        public void TakeDamage(float damage)
        {
            Health -= damage; // Decrease health by damage amount
            XP += (int)(damage / 20); // Increase XP based on damage taken
        }

        // Constructor that accepts the player's name and initializes the stats
        // Omitted values (xp = 0, health = MaxHealth)
        public Player(string name)
        {
            Name = name; // Set the player's name
            xp = 0; // Initialize XP to 0
            health = MaxHealth; // Initialize health to MaxHealth
        }
    }
}
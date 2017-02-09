using System;
using System.Collections.Generic;

namespace BlackJack{
    // This section holds all the players in the game, and allows turn order to be tracked.
    public class Table
    {
        // This list holds the Players in the game.
        public List<Player> PlayerList= new List<Player>();

        // Constructs a new table.
        public Table(int PlayerCount = 1)
        {
            // Creates a player, named "RoboDealer"
            Player dealer = new Player("RoboDealer");
            // Sets the isDealer boolean flag to true.
            dealer.isDealer = true; 
            // Adds the RoboDealer to position 0 in the list.
            PlayerList.Add(dealer);
            // Taunts the players.
            Console.WriteLine("The dealer has arrived at the table, and awaits fools to chalange it to a game of Blackjack!")
            // For each player expected
            for (int i = 0; i < PlayerCount; i++)
            {
                Console.WriteLine("Player {0}, what is your name?");
                string InputLine = Console.ReadLine();
            }
            Console.WriteLine("The players are all seated, and we can now begin our game of skill and chance!")
        }
    }
}
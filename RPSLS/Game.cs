using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        public Player player1;
        public Player player2;
        int roundsPlayed;
        public Game()
        {
            roundsPlayed = 0;
        }

        public void GetPlayers()
        {
            Console.WriteLine("Are you playing with a friend?");
            string numberOfPlayers = Console.ReadLine();

            player1 = new Human();
            player2 = new Human();

            if (numberOfPlayers == "yes")
            {
                player1.SetPlayerName();
                player2 = new Human();
                player2.SetPlayerName();

            }
            else
            {
                player2 = new Computer();
                player1.SetPlayerName();
            }
        }

        public void DetermineRoundWinner()
        {
            if (player1.playersChoice == player2.playersChoice)
            {
                Console.WriteLine(player1.playersName + " threw down " + player1.playersChoice + " and " + player2.playersName + " threw down " + player2.playersChoice);
                Console.WriteLine("Tie!");
            }
            else if (player1.playersChoice == "rock" && (player2.playersChoice == "scissors" || player2.playersChoice == "lizard"))
            {
                player1.increaseScore();
                roundsPlayed++;
                Console.WriteLine(player1.playersName + " threw down " + player1.playersChoice + " and " + player2.playersName + " threw down " + player2.playersChoice);
                Console.WriteLine(player1.playersChoice + " beats " + player2.playersChoice + "!");
            }
            else if (player1.playersChoice == "scissors" && (player2.playersChoice == "paper" || player2.playersChoice == "lizard"))
            {
                player1.increaseScore();
                roundsPlayed++;
                Console.WriteLine(player1.playersName + " threw down " + player1.playersChoice + " and " + player2.playersName + " threw down " + player2.playersChoice);
                Console.WriteLine(player1.playersChoice + " beats" + player2.playersChoice + "!");
            }
            else if (player1.playersChoice == "paper" && (player2.playersChoice == "rock" || player2.playersChoice == "spock"))
            {
                player1.increaseScore();
                roundsPlayed++;
                Console.WriteLine(player1.playersName + " threw down " + player1.playersChoice + " and " + player2.playersName + " threw down " + player2.playersChoice);
                Console.WriteLine(player1.playersChoice + " beats " + player2.playersChoice + "!");
            }
            else if (player1.playersChoice == "lizard" && (player2.playersChoice == "spock" || player2.playersChoice == "paper"))
            {
                player1.increaseScore();
                roundsPlayed++;
                Console.WriteLine(player1.playersName + " threw down " + player1.playersChoice + " and " + player2.playersName + " threw down " + player2.playersChoice);
                Console.WriteLine(player1.playersChoice + " beats " + player2.playersChoice + "!");
            }
            else if (player1.playersChoice == "spock" && (player2.playersChoice == "scissors" || player2.playersChoice == "rock"))
            {
                player1.increaseScore();
                roundsPlayed++;
                Console.WriteLine(player1.playersName + " chose " + player1.playersChoice + " and " + player2.playersName + " chose " + player2.playersChoice);
                Console.WriteLine(player1.playersChoice + " beats " + player2.playersChoice + "!");
            }
            else
            {
                player2.increaseScore();
                roundsPlayed++;
                Console.WriteLine(player1.playersName + " threw down " + player1.playersChoice + " and " + player2.playersName + " threw down " + player2.playersChoice);
                Console.WriteLine(player2.playersChoice + " beats " + player2.playersChoice + "!");
            }
        }




        public void GetPlayerChoices()
        {
            player1.MakePlayerChoice();
            player2.MakePlayerChoice();
        }

        public void EndGame()
        {

        }
        public void RunGame()
        {
            GetPlayers();

            while (player1.numberOfRoundsWon < 3 && player2.numberOfRoundsWon < 3)
            {
                GetPlayerChoices();
                DetermineRoundWinner();
            }

            EndGame();
        }
    }
}

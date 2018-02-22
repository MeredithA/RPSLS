using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    abstract class Player
    {
        protected List<string> listOfChoices = new List<string> { "rock", "paper", "scissors", "lizard", "spock" };
        public string playersChoice;
        public int numberOfRoundsWon;
        public string playersName;


        public abstract void SetPlayerName();

        public abstract void MakePlayerChoice();

        internal void increaseScore()
        {
            numberOfRoundsWon++;
        }
    }
}

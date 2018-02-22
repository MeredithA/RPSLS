using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human : Player
    {
        public Human()
        {
            numberOfRoundsWon = 0;
        }
        public override void SetPlayerName()
        {
            Console.WriteLine("What is your name?");
            playersName = Console.ReadLine();
        }

        public override void MakePlayerChoice()
        {
            Console.WriteLine(playersName + " do you choose rock, paper, scissors, lizard or spock?");
            playersChoice = Console.ReadLine();
        }

    }
}

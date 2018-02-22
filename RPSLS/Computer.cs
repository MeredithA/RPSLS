using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Computer : Player
    {
        Random random;
        public Computer()
        {
            random = new Random();
            numberOfRoundsWon = 0;
        }
        public override void MakePlayerChoice()
        {
            int choice = random.Next(0, listOfChoices.Count);
            playersChoice = listOfChoices[choice];
        }


        public override void SetPlayerName()
        {
            playersName = "SmarterChild";
        }
    }
}

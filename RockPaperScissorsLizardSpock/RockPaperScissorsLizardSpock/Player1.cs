using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Player1 : Amy_Fowler
    {
        public Player1()
        {
            this.playerName = UserNameNeeded();
            this.levelsWon = 0;
        }

        private string UserNameNeeded()
        {
            Console.WriteLine("Player 1, Please enter in a name:");
            playerName = Console.ReadLine();
            return playerName;
        }

        public override void ShowLevelsWon()
        {
            Console.WriteLine(playerName + "wins" + levelsWon + "round(s)");
        }
    }
}
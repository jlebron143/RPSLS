using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public abstract class Amy_Fowler
    {
        public string playerName;
        public int levelsWon;
        public string playPick;

        public string UserChoice()
        {
            Console.WriteLine();
            Console.WriteLine(playerName + "Choose from the following : (1) Rock, (2) Paper, (3) Lizard, (4) Scissors, (5) Spock");
            playPick = Console.ReadLine();
            switch (playPick)
            {
                case "1":
                    return playPick = "Rock";
                case "2":
                    return playPick = "Paper";
                case "3":
                    return playPick = "Scissors";
                case "4":
                    return playPick = "Lizard";
                case "5":
                    return playPick = "Spock";
                default:
                    Console.WriteLine("You must enter 1,2,3,4 or 5");
                    return UserChoice();
            }
        }

        public abstract void ShowLevelsWon(); 

        public int TransChoiceToNumber(string pick)
        {
            if (pick == "Rock")
            {
                return 0;
            }
            if (pick == "paper")
            {
                return 1;
            }
            if (pick == "Scissors")
            {
                return 2;
            }
            if (pick == "Lizard")
            {
                return 3;
            }
            if (pick == "Spock")
            {
                return 4;
            }
            return TransChoiceToNumber(pick);
        }
    }
}
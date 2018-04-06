using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Player2 : Amy_Fowler
    {
        private string player2Choice;
        public bool actualPerson;
        Random rnd = new Random();
        private int go;

        public Player2()
        {
            NeedToKnowWhoIsPlayerTwo();
        }

        public void NeedToKnowWhoIsPlayerTwo()
        {
            Console.WriteLine("Who is player 2 , a (1) Human OR () CPU?");
            player2Choice = Console.ReadLine();
            switch (player2Choice)
            {
                case"1":
			Console.WriteLine("Player 2, Please enter in a name.");
                    playerName = Console.ReadLine();
                    actualPerson = true;
                    break;

                case"2":
			Console.WriteLine("Player 2 will be CPU.");
                    playerName = "Amy Fowler";
                    break;

                default:
                    Console.WriteLine("You must enter in 1 or 2.....");
                    NeedToKnowWhoIsPlayerTwo();
    
            break;
            }
        }

        public override void ShowLevelsWon()
        {
            Console.WriteLine(playerName + "wins" + levelsWon + " round(s)");
        }

        public string AmyGetsToChoose()
        {
            Console.WriteLine(playerName + "Choose from the following: (1) Rock, (2) Paper, (3) Lizard , (4) Scissors , (5) Spock");
            go = rnd.Next(1, 5);
            switch (go)
            {
                case 1:
                    return playPick = "Rock";
                case 2:
                    return playPick = "Paper";
                case 3:
                    return playPick = "Lizard";
    
            case 4:
                    return playPick = "Scissors";
                case 5:
                    return playPick = "Spock";
                default:
                    return AmyGetsToChoose();
            }
        }
    }
}
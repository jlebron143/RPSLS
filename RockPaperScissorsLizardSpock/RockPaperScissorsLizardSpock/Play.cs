using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
        class Play
        {


        Player1 player1;
        Player2 player2;
        private int tempPlayPick1;
        private int tempPlayPick2;
        private int roundCount;
        private string levelWinner;

        public Play()
        {
            OpeningStatement();
            ShowPlayersNames();
            player1 = new Player1();
            player2 = new Player2();
            roundCount = 1;
        }


        private void OpeningStatement()
        {

            Console.WriteLine("Hello!");
            Console.WriteLine("Welcome to Sheldon's Rock-Paper-Scissors-Lizard-Spock.");
            Console.WriteLine("Here are the rules!");
            Console.WriteLine("Each player will make a choice to throw (Rock, Paper, Scissors, Lizard , Spock)");
            Console.WriteLine("Now pay close attention........ ");
            Console.WriteLine("Paper cover Rock");
            Console.WriteLine("Scissors cuts Paper");
            Console.WriteLine("Rock crushers Scissors");
            Console.WriteLine("Lizard eats Paper");
            Console.WriteLine("Rock Crushes Lizard");
            Console.WriteLine("Scissors decapitates Lizard");
            Console.WriteLine("Lizard poisons Spock");
            Console.WriteLine("Spock vaporizes Rock");
            Console.WriteLine("Spock smashes Scissors");
            Console.WriteLine("Paper disproves Spock");
            Console.WriteLine("..... did you get all that? I know its a lot but its important to know");
            Console.WriteLine("This game is played between two players.");
            Console.WriteLine("The best out of 3 wins the game");
            Console.WriteLine("I hope you're ready. Let's have some fun!");
        }

        public void RunGame()
        {

            player1.UserChoice();
            if (player2.actualPerson == true)
            {
                player2.UserChoice();
            }
            else
            {
                player2.AmyGetsToChoose();
            }
            ShowUserChoice();
            tempPlayPick1 = player1.TransChoiceToNumber(player1.playPick);
            tempPlayPick2 = player2.TransChoiceToNumber(player2.playPick);
            DecideRoundWinner(tempPlayPick1, tempPlayPick2);
            player1.ShowLevelsWon();
            player2.ShowLevelsWon();
            if (player1.levelsWon == 2)
            {
                ShowWinner(player1.playerName);
            }
            else if (player2.levelsWon == 2)
            {
                ShowWinner(player2.playerName);
            }
            else
            {
                RunGame();
            }

        }

        private void ShowWinner(string playerName)
        {
            Console.WriteLine("Game Over!" + playerName + " is the winner!!!");
        }

        private void ShowUserChoice()
        {
            Console.WriteLine("Round" + roundCount);
            Console.WriteLine(player1.playerName + "chose" + player1.playPick);
            Console.WriteLine(player2.playerName + "chose" + player2.playPick);
        }

        private void ShowPlayersNames()
        {
            Console.WriteLine("Player1: " + player1.playerName);
            Console.WriteLine("Player2: " + player2.playerName);
            Console.WriteLine("Best of Luck! Now Begin....");
       }


        private void DecideRoundWinner(int pick1, int pick2)
        {
            int finalRoundWinner;
            finalRoundWinner = (5 + pick1 - pick2) % 5;
            if (finalRoundWinner == 0)
            {
                Console.WriteLine("Looks like we have a Tie.....");
                Console.WriteLine();
                roundCount += 1;
            }
            else if (finalRoundWinner == 1 || finalRoundWinner == 3)
            {
                levelWinner = player1.playerName;
                Console.WriteLine("The winner of this round is" + levelWinner.ToUpper());
                Console.WriteLine();
                player1.levelsWon += 1;
                roundCount += 1;
            }
            else if (finalRoundWinner == 2 || finalRoundWinner == 4)
            {
                levelWinner = player2.playerName;
                Console.WriteLine("The winner of this round is" + levelWinner.ToUpper());
                Console.WriteLine();
                player2.levelsWon += 1;
                roundCount += 1;
            }
        }
    }
}







 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPSLP
{
    public abstract class Game
    //setters make the object mutable, getters violate "Tells an object what to do, doesn't ask it for info and manipulates it."
    //A private setter is useful if you have a read only property and don't want to explicitly declare the backing variable.
    //The presence of a private setter is because you can use auto property.
    //Automatic Properties are used when no additional logic is required in the property accessors.
    //these are used to make it easier to have private variables in the class, but allow them to be visible to outside the class 

    //does a game have a player?
    { public abstract int CompareTo(Game other);
      public string Name { get { return GetType().Name; } }
     public abstract string GetWinningWord(Game other);


        int roundsPlayed { get; set; }
        int playerwins { get; set; }
        int computerWins { get; set; }

         bool computerWon { get; set; }  
         bool playerWon { get; set; }
         bool tiedGame { get; set; }

        IContender player { get; set; }
        IContender computer { get; set; }

        public Game(IContender player, IContender computer)
        {
            this.player = player;
            this.computer = computer;
            this.roundsPlayed = 0;
            this.playerwins = 0;
            this.computerWins = 0;
              
            this.player.Played += player_played;
            this.computer.Played += computer._played;

        }

        //member methods
        void computer_played(object sender, string option)
        {
            LookIfWin();
            player.Play();

        }

        void player_played(object sender, string option)
        {
            computer.play();
        }

        void LookIfWin()
        {
            tiedGame = false;
            computerWon = false;
            playerWon = false;
        }
        // stuff below needs to be in method
        public void compareChoice()
        {
            if (Player.CurrentOption == "Rock" && Computer.CurrentOption == "Rock")
            {
                tiedGame = true;
            }

            if (Player.CurrentOption == "Paper" && Computer.CurrentOption == "Paper")
            {
                tiedGame = true;
            }

            if (Player.CurrentOption == "Scissors" && Computer.CurrentOption == "Scissors")
            {
                tiedGame = true;
            }

            if (Player.CurrentOption == "Lizard" && Computer.CurrentOption == "Scissors")
            {
                tiedGame = true;
            }

            if (Player.CurrentOption == "Spock" && Computer.CurrentOption == "Spock")
            {
                tiedGame = true;
            }


            gamesPlayed++;

            if (RoundFinished != null)
                RoundFinished(this, new EventArgs());


        }
        }

    }

}




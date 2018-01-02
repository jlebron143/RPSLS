using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLP
{
    class Computer : Icontender
    {
        string[] options = new string[5] { "Rock", "Paper", "Scissors", "Lizard", "Spock" }

        Random r = new Random();
        String CurrentOption { set; get}

        public void Play ()
    }
        int randomChoice = r.Next(options.Count());
        string randomString = options[randomChoice];

        this.CurrentOption = randomString;

            if(played ! = null)

        {
              played(this, randomString);
    }



}
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLP
{
    public class Paper : Game
    {
        public override string GetWinningWord(Game other)
        {
            if (other is Rock) return "covers";
            if (other is Spock) return "disproves";

           
        }

        public override int CompareTo(Game other)
        {
            if (other is Rock) return 1;
            if (other is Paper) return 0;
            if (other is Scissors) return -1;
            if (other is Lizard) return -1;
            if (other is Spock) return 1;

           
        }
    }

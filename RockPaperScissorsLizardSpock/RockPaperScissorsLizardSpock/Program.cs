using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissorsLizardSpock
{
   class Program
	{
		static void Main(string[] args)
		{
		
		    Play play = new Play();
            play.RunGame();
            Console.ReadKey();
		}
	}
}

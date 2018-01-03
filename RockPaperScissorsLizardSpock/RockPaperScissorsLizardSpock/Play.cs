﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
        class Play
        {



            string inputPlayer, inputCPU;
            int randomInt;
            int scorePlayer = 0;
            int scoreCPU = 0;
            bool playAgain = true;


            public void Game (bool playAgain, int scoreCPU, int scorePlayer)
            {
                while (scorePlayer < 5 || scoreCPU < 5)
                {
                    //scorePlayer = 0;
                    //scoreCPU = 0;

                }
            }



            public void Rules(string inputPlayer, int randomInt)
            {
                Console.Write("Choose between Rock, Paper, Scissors, Lizard , Spock. Best out of five wins the game.");
                inputPlayer = Console.ReadLine();
                inputPlayer = inputPlayer.ToLower();

                Random rnd = new Random();

                randomInt = rnd.Next(1, 6);
            }
            public void RunGame(string inputPlayer, string inputCPU, int randomInt, int scoreCPU, int scorePlayer)
            {
                switch (randomInt)
                {
                    case 1:
                        inputCPU = "Rock";
                        Console.WriteLine("Computer chose Rock");
                        if (inputPlayer == "Rock")
                        {
                            Console.WriteLine("Draw!\n\n");
                        }
                        else if (inputPlayer == "Paper")
                        {
                            Console.WriteLine("Player Wins! Paper covers Rock!\n\n");
                            scorePlayer++;
                        }
                        else if (inputPlayer == "Scissors")

                        {
                            Console.WriteLine("CPU Wins! Rock smashes Scissors!\n\n");
                            scoreCPU++;
                        }
                        else if (inputPlayer == "Lizard")
                        {
                            Console.WriteLine("CPU Wins! Rock crushes Lizard!\n\n");

                            scoreCPU++;
                        }
                        else if (inputPlayer == "Spock")
                        {
                            Console.WriteLine("CPU Wins! Spock vaporizes Rock!\n\n");
                            scoreCPU++;
                        }
                        break;
                    case 2:
                        inputCPU = "Paper";
                        Console.WriteLine("Computer chose Paper");
                        if (inputPlayer == "Paper")
                        {
                            Console.WriteLine("Draw!\n\n");
                        }
                        else if (inputPlayer == "Rock")
                        {
                            Console.WriteLine("CPU Wins! Paper covers Rock!\n\n");
                            scoreCPU++;
                        }
                        else if (inputPlayer == "Scissors")
                        {
                            Console.WriteLine("Player Wins! Scissors cuts Paper!\n\n");
                            scoreCPU++;
                        }
                        else if (inputPlayer == "Lizard")
                        {
                            Console.WriteLine("Player Wins! Lizard eats Paper!\n\n");
                            scorePlayer++;
                        }
                        else if (inputPlayer == "Spock")
                        {
                            Console.WriteLine("CPU Wins! Paper disproves Spock!\n\n");
                            scoreCPU++;
                        }
                        break;
                    case 3:
                        inputCPU = "Scissors";
                        Console.WriteLine("Computer chose Scissors!");
                        if (inputPlayer == "Scissors")
                        {
                            Console.WriteLine("Draw!\n\n");

                        }
                        else if (inputPlayer == "Rock")
                        {
                            Console.WriteLine("Player Wins! Rock crushes Scissors!\n\n");
                            scorePlayer++;
                        }
                        else if (inputPlayer == "Paper")
                        {
                            Console.WriteLine("CPU Wins! Scissors cuts Paper!\n\n");
                            scoreCPU++;
                        }
                        else if (inputPlayer == "Lizard")
                        {
                            Console.WriteLine("CPU Wins! Scissors decapitates Lizard!\n\n");
                            scoreCPU++;
                        }
                        else if (inputPlayer == "Spock")
                        {
                            Console.WriteLine("Player Wins! Spock smashes Scissors!\n\n");
                            scorePlayer++;
                        }
                        break;

                    case 4:
                        inputCPU = "Lizard";
                        Console.WriteLine("Computer chose Lizard!");
                        if (inputPlayer == "Lizard")
                        {
                            Console.WriteLine("Draw!\n\n");

                        }
                        else if (inputPlayer == "Rock")
                        {
                            Console.WriteLine("Player Wins!Rock crushes lizard!\n\n");
                            scorePlayer++;
                        }
                        else if (inputPlayer == "Paper")
                        {
                            Console.WriteLine("CPU Wins!Lizard eats Paper!\n\n");
                            scoreCPU++;
                        }
                        else if (inputPlayer == "Scissors")
                        {
                            Console.WriteLine("Player Wins! Scissors decapitates Lizard!\n\n");
                            scorePlayer++;
                        }
                        else if (inputPlayer == "Spock")
                        {
                            Console.WriteLine("Player Wins! Lizard poisons Spock!\n\n");
                            scorePlayer++;
                        }
                        break;

                    case 5:
                        inputCPU = "Spock";
                        Console.WriteLine("Computer chose Spock!");
                        if (inputPlayer == "Spock")
                        {
                            Console.WriteLine("DRAW!! \n\n");
                        }
                        else if (inputPlayer == "Rock")
                        {
                            Console.WriteLine("CPU Wins! Spock vaporizes Rock!\n\n");
                            scoreCPU++;
                        }
                        else if (inputPlayer == "Paper")
                        {
                            Console.WriteLine("Player Wins! Paper disproves Spock!\n\n");
                            scorePlayer++;
                        }
                        else if (inputPlayer == "Scissors")
                        {
                            Console.WriteLine("CPU Wins!Spock smashes Scissors!\n\n");
                            scoreCPU++;
                        }
                        else if (inputPlayer == "Lizard")
                        {
                            Console.WriteLine("Player Wins! Lizard Poisons Spock!!\n\n");
                            scorePlayer++;
                        }
                        break;
                    default:
                        Console.WriteLine("Invaild entry!");
                        break;
                }
            }


            public void Winner(int scorePlayer, int scoreCPU)
            {
                Console.WriteLine("\n\nScores:\tPlayer:/t{0}\tCPU:t{1}", scorePlayer, scoreCPU);

                if (scorePlayer == 5)
                {
                    Console.WriteLine("Player Wins!");
                }
                else if (scoreCPU == 5)
                {
                    Console.WriteLine("CPU Wins!");
                }
                else
                {

                }
            }


            public void newGame(bool playAgain)
            {
                Console.WriteLine("Would you like to play again?(y/n)");
                string loop = Console.ReadLine();
                if (loop == "y")
                {
                    playAgain = true;
                    Console.Clear();
                }
                else if (loop == "n")
                {
                    playAgain = false;

                }
            }
        }
    }
//}



















using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Media;
using System.Speech.Synthesis;
// A console app that will play Tic-Tac-Toe with you.

namespace Tic_Tac_Toe
{
    class Program
    {
        //variables
        static string one = "1";
        static string two = "2";
        static string three = "3";
        static string four = "4";
        static string five = "5";
        static string six = "6";
        static string seven = "7";
        static string eight = "8";
        static string nine = "9";
        static bool gameResult = false;
        static bool UserOrPc = false; // false = User wins. true = PC wins.
        static int wins;
        static int totalGames;
        static int userChoice;
        static int botChoice;
        static int counter;
      //  static int vs;


        static SoundPlayer s = new SoundPlayer((Properties.Resources.TheFatRat___Epic));
        static void PlayMusic()
        {
            //a function that will handle the music playback

            while (true)
            {
                s.Play();
                Thread.Sleep(179000);
            }
        }


        static void CheckForWin()
        {
           //this function checks each turn if the user or the computer has won.

            //checks if the user has won
           if(one == "X" && two == "X" && three == "X")
            {
				var color = Console.ForegroundColor;
                gameResult = true;

            }
            if ( four == "X" && five == "X" && six == "X")
            {
				var color = Console.ForegroundColor;
				gameResult = true;
            }
            if (seven == "X" && eight == "X" && nine == "X")
            {
				var color = Console.ForegroundColor;
				gameResult = true;
            }
            if (one == "X" && four == "X" && seven == "X")
            {
				var color = Console.ForegroundColor;
				gameResult = true;
            }
            if (two  == "X" && five == "X" && eight == "X")
            {
				var color = Console.ForegroundColor;
				gameResult = true;
            }
            if (three == "X" && six == "X" && nine == "X")
            {
				var color = Console.ForegroundColor;
				gameResult = true;
            }
            if (one == "X" && five == "X" && nine == "X")
            {
				var color = Console.ForegroundColor;
				gameResult = true;
            }
            if (seven == "X" && five == "X" && three == "X")
            {
				var color = Console.ForegroundColor;
				gameResult = true;
            }

			if (gameResult == true)
			{
				
				goto End; 
			}

            //checks if the computer has won
            if (one == "O" && two == "O" && three == "O")
            {
				var color = Console.ForegroundColor;
				gameResult = true;
                UserOrPc = true;
            }
            if (four == "O" && five == "O" && six == "O")
            {
				var color = Console.ForegroundColor;
				gameResult = true;
                UserOrPc = true;
            }
            if (seven == "O" && eight == "O" && nine == "O")
            {
				var color = Console.ForegroundColor;
				gameResult = true;
                UserOrPc = true;
            }
            if (one == "O" && four == "O" && seven == "O")
            {
				var color = Console.ForegroundColor;
				gameResult = true;
                UserOrPc = true;
            }
            if (two == "O" && five == "O" && eight == "O")
            {
				var color = Console.ForegroundColor;
				gameResult = true;
                UserOrPc = true;
            }
            if (three == "O" && six == "O" && nine == "O")
            {
				var color = Console.ForegroundColor;
				gameResult = true;
                UserOrPc = true;
            }
            if (one == "O" && five == "O" && nine == "O")
            {
				var color = Console.ForegroundColor;
				gameResult = true;
                UserOrPc = true;
            }
            if (seven == "O" && five == "X" && three == "X")
            {
				var color = Console.ForegroundColor;
				gameResult = true;
                UserOrPc = true;
            }

            End:
			{

			}

        }

        static void DrawUI()
        {
            //this function draws the board and instructs the user on how to play
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Games Played:" + totalGames);
            Console.WriteLine("        " + "Wins:" + wins);
            Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("                    _______");
            Console.WriteLine("                    |" + one + "|"+ two + "|" + three + "|");
            Console.WriteLine("                    |" + four + "|" + five + "|" + six + "|");
            Console.WriteLine("                    |" + seven + "|" + eight + "|" + nine + "|");
			Console.WriteLine("                    _______");
			Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("To play type the number you want to change to X and hit enter.");
        }

        static void Main()
        {
			Console.Title = "Tic Tac Toe";
            SpeechSynthesizer synth = new SpeechSynthesizer();
            Random r = new Random();
            Thread MusicWorker = new Thread(PlayMusic);
            MusicWorker.Start();

		/*	for (int i = 1; i < 56; i++)
			{
				Console.SetWindowSize(i, i);
				Thread.Sleep(6);
			}*/
			Console.SetWindowSize(65, 20);
			

            Main:
            {
                //reseting vars
                one = "1";
                two = "2";
                three = "3";
                four = "4";
                five = "5";
                six = "6";
                seven = "7";
                eight = "8";
                nine = "9";
               // vs = 0;
                userChoice = 0;
                botChoice = 0;
                counter = 0;
                gameResult = false;
                UserOrPc = false;

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Tic Tac Toe v1.0 by Kalin Lalov");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("-------------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Green;
                Thread.Sleep(150);
				Console.WriteLine("Press any key to start the game!");
				Console.ReadKey();
              //  Console.WriteLine("");
              //  Console.WriteLine("Type 0 to play vs the computer or 1 to play vs another player...");
           /*     try
                {
                    vs = int.Parse(Console.ReadLine());
                    if (vs < 0 || vs > 1)
                    {
                        vs = 0;
                        Console.Clear();
                        Console.WriteLine("The specified value is incorrect. Type either 0 or 1");
                        Thread.Sleep(2500);
                        Console.Clear();
                        goto Main;
                        
                    }
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("That`s not a number!");
                    Thread.Sleep(2000);
                    vs = 0;
                    goto Main;
                }*/
             
                Console.Clear();
                UsersTurn:
                {
                    Console.Clear();
                    DrawUI();
                    try
                    {
                        userChoice = int.Parse(Console.ReadLine());

                        if (userChoice < 1 || userChoice > 9)
                        {
                            userChoice = 0;
                            Console.Clear();
                            Console.WriteLine("Wrong.You must enter a number between 1 and 9");
                            Thread.Sleep(4000);
                            Console.Clear();
                            goto UsersTurn;

                        }
                        switch (userChoice)
                        {

                            case 1:

                                if (one == "X" || one == "O")
                                {
                                    Console.Clear();
                                    Console.WriteLine("This slot is already taken. Choose another one.");
                                    Thread.Sleep(4000);
                                    userChoice = 0;
                                    Console.Clear();
                                    goto UsersTurn;
                                }
                                one = "X";

                                break;
                            case 2:
                                if (two == "X" || two == "O")
                                {
                                    Console.Clear();
                                    Console.WriteLine("This slot is already taken. Choose another one.");
                                    Thread.Sleep(4000);
                                    userChoice = 0;
                                    Console.Clear();
                                    goto UsersTurn;
                                }
                                two = "X";
                                break;
                            case 3:
                                if (three == "X" || three == "O")
                                {
                                    Console.Clear();
                                    Console.WriteLine("This slot is already taken. Choose another one.");
                                    Thread.Sleep(4000);
                                    userChoice = 0;
                                    Console.Clear();
                                    goto UsersTurn;
                                }
                                three = "X";
                                break;
                            case 4:
                                if (four == "X" || four == "O")
                                {
                                    Console.Clear();
                                    Console.WriteLine("This slot is already taken. Choose another one.");
                                    Thread.Sleep(4000);
                                    userChoice = 0;
                                    Console.Clear();
                                    goto UsersTurn;
                                }
                                four = "X";
                                break;
                            case 5:
                                if (five == "X" || five == "O")
                                {
                                    Console.Clear();
                                    Console.WriteLine("This slot is already taken. Choose another one.");
                                    Thread.Sleep(4000);
                                    userChoice = 0;
                                    Console.Clear();
                                    goto UsersTurn;
                                }
                                five = "X";
                                break;
                            case 6:
                                if (six == "X" || six == "O")
                                {
                                    Console.Clear();
                                    Console.WriteLine("This slot is already taken. Choose another one.");
                                    Thread.Sleep(4000);
                                    userChoice = 0;
                                    Console.Clear();
                                    goto UsersTurn;
                                }
                                six = "X";
                                break;
                            case 7:
                                if (seven == "X" || seven == "O")
                                {
                                    Console.Clear();
                                    Console.WriteLine("This slot is already taken. Choose another one.");
                                    Thread.Sleep(4000);
                                    userChoice = 0;
                                    Console.Clear();
                                    goto UsersTurn;
                                }
                                seven = "X";
                                break;
                            case 8:
                                if (eight == "X" || eight == "O")
                                {
                                    Console.Clear();
                                    Console.WriteLine("This slot is already taken. Choose another one.");
                                    Thread.Sleep(4000);
                                    userChoice = 0;
                                    Console.Clear();
                                    goto UsersTurn;
                                }
                                eight = "X";
                                break;
                            case 9:
                                if (nine == "X" || nine == "O")
                                {
                                    Console.Clear();
                                    Console.WriteLine("This slot is already taken. Choose another one.");
                                    Thread.Sleep(4000);
                                    userChoice = 0;
                                    Console.Clear();
                                    goto UsersTurn;
                                }
                                nine = "X";
                                break;


                        }


                    }
                    catch/* em all */(Exception)
                    {
                        Console.Clear();
                        Console.WriteLine("That`s not a number!");
                        Thread.Sleep(2000);
                        userChoice = 0;
                        Console.Clear();
                        goto UsersTurn;


                    }
                }

                ComputerChooses:
                {
                    botChoice = r.Next(1, 9);
                    switch (botChoice)
                    {

                        case 1:
                            if (one == "X" || one == "O")
                            {
                                botChoice = 0;
                                goto ComputerChooses;
                            }
                            one = "O";
                            break;
                        case 2:
                            if (two == "X" || two == "O")
                            {
                                botChoice = 0;
                                goto ComputerChooses;
                            }
                            two = "O";
                            break;
                        case 3:
                            if (three == "X" || three == "O")
                            {
                                botChoice = 0;
                                goto ComputerChooses;
                            }
                            three = "O";
                            break;
                        case 4:
                            if (four == "X" || four == "O")
                            {
                                botChoice = 0;
                                goto ComputerChooses;
                            }
                            four = "O";
                            break;
                        case 5:
                            if (five == "X" || five == "O")
                            {
                                botChoice = 0;
                                goto ComputerChooses;
                            }
                            five = "O";
                            break;
                        case 6:
                            if (six == "X" || six == "O")
                            {
                                botChoice = 0;
                                goto ComputerChooses;
                            }
                            six = "O";
                            break;
                        case 7:
                            if (seven == "X" || seven == "O")
                            {
                                botChoice = 0;
                                goto ComputerChooses;
                            }
                            seven = "O";
                            break;
                        case 8:
                            if (eight == "X" || eight == "O")
                            {
                                botChoice = 0;
                                goto ComputerChooses;
                            }
                            eight = "O";
                            break;
                        case 9:
                            if (nine == "X" || nine == "O")
                            {
                                botChoice = 0;
                                goto ComputerChooses;
                            }
                            nine = "O";
                            break;

                    }
                    Console.Clear();
                    DrawUI();
                    CheckForWin();
	
						counter++;
						if (gameResult == true)
						{
							

							Thread.Sleep(2000);
							if (UserOrPc == true)
							{
								//PC wins
								Console.Clear();
								Console.ForegroundColor = ConsoleColor.Red;
								Console.WriteLine("You lost! Press any key to try again");
								synth.Speak("You lost! Press any key to try again");
								totalGames++;
								Console.ReadKey();
								Console.Clear();
								goto Main;
							}
							else
							{
								//User wins
								Console.Clear();
								Console.ForegroundColor = ConsoleColor.Red;
								Console.WriteLine("You won! Press any key to play again");
								synth.Speak("You won!!! Press any key to play again");
								totalGames++;
								wins++;
								Console.ReadKey();
								Console.Clear();
								goto Main;
							}

						}
					
                    if (counter == 4)
                    {  //draw. No one has won.
                        CheckForWin();
                        if (gameResult == false)
                        {
                            Thread.Sleep(2000);
                            Console.Clear();
                            Console.WriteLine("Draw. Press any key to play again");
                            Console.ReadKey();
                            Console.Clear();
                            totalGames++;
                            goto Main;
                        }
                    }
                    goto UsersTurn;
                }
            }
        }
    }
}
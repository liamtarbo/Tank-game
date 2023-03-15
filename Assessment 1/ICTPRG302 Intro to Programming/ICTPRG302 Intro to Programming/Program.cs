using System;
using System.IO;

namespace ICTPRG302_Intro_to_Programming
{
	class Program
	{
		/// <summary>
		/// This is the starting location for the program.
		/// </summary>
		/// <param name="args">
		/// A list of strings passed in to the program
		/// from the command-line when it was started
		/// </param>
		static void Main(string[] args)
		{
			




			GamerTags gamertags = new GamerTags();


			gamertags.LoadGamertags();
			gamertags.WelcomeMessage();
			gamertags.PrintAllGamertags();
            gamertags.PrintAllGamertagsEndingInNumber();
			gamertags.PrintAllGamertagsEndingwithnumberordigit();

            
			
			bool isrunning = true;

            while (isrunning)
            {
                Console.WriteLine("*** Program sequence output-display gamertags etc***");

                Console.WriteLine("Would you like to view the gamertags again (y/n)");

				if (Console.ReadKey().Key == ConsoleKey.Y)
				{
					isrunning = true;
				}
				else
				{
					isrunning = false;
				}
            }

        }
	}
}

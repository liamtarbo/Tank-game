using System;
using System.IO;
using System.Net.NetworkInformation;

namespace ICTPRG302_Intro_to_Programming
{
    internal class GamerTags
    {
        // The list of gamer Tags loaded from file 
        private string[] gamerTaglist = { };

        //Load a list of gamertags from file and store 
        //the resualting list in our gamertaglist

        public void LoadGamertags()
        {
            gamerTaglist = File.ReadAllLines("../Gamertags.txt");

        }
        public void PrintAllGamertags()
        {
            Console.Clear();
            Console.WriteLine("----------------");
            Console.WriteLine("All gamertags");
            Console.WriteLine("----------------");

            int linenumber = 1;
            foreach (string s in gamerTaglist)
                
            {

               Console.WriteLine(linenumber.ToString() + ") " + s);

                linenumber = linenumber + 1;

            }


            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
        public void PrintAllGamertagsEndingInNumber()
        {
            Console.Clear();
            Console.WriteLine("----------------");
            Console.WriteLine("All gamertags ending with numbers");
            Console.WriteLine("----------------");

            int linenumber = 1;
            foreach (string s in gamerTaglist)

            {
                if ((s.Length > 0) && Char.IsNumber(s, s.Length - 1))


                    Console.WriteLine(linenumber.ToString() + ") " + s);

                linenumber = linenumber + 1;

            }


            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
        public void PrintAllGamertagsEndingwithnumberordigit()
        {
            Console.Clear();
            Console.WriteLine("----------------");
            Console.WriteLine("All gamertags not starting with letters or numbers");
            Console.WriteLine("----------------");

            int linenumber = 1;
            foreach (string s in gamerTaglist)

            {
                if ((s.Length > 0) && !Char.IsLetterOrDigit(s,0))


                    Console.WriteLine(linenumber.ToString() + ") " + s);

                linenumber = linenumber + 1;

            }


            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        public void WelcomeMessage()
        {
            Console.WriteLine("-----------");
            Console.WriteLine("Welcome to Gamertag data!");
            Console.WriteLine("-----------");



            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }


        

            








    }
}











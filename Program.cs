using System;

namespace Monopoly
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menuInst = new Menu();

            menuInst.Intro();
            
        }
    }

    class Menu
    {

        public void Intro()
        {
            Console.WriteLine("Hello! Please enter the section of the application" +
            " you would like to use. \nYour choices are below. \n\nTournament | Players\n");

            string menuSelect = Console.ReadLine().ToLower();
            
            if (menuSelect == "tournament")
            {
                TournamentOptions();
            }
            else if (menuSelect == "players")
            {
                PlayersOptions();
            }
        }

        public void TournamentOptions()
        {
            Console.WriteLine("Hello! Please enter the section of the application" +
            " you would like to use. \nYour choices are below. \n\nAdd Tournament | Remove Tournament\n");

            string tournMenuSelect = Console.ReadLine().ToLower();

            if (tournMenuSelect == "add tournament")
            {
                //AddTournament();
            }
            else if (tournMenuSelect == "remove tournament")
            {
                //RemoveTournament();
            }
        }

        public void PlayersOptions()
        {
            Console.WriteLine("\nPlayers Section");
        }
    }
}


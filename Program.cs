using System;
using System.Collections.Generic;
using static System.Console;

namespace Monopoly
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menuInst = new Menu();
            List<Tournament> Tournaments = new List<Tournament>();

            menuInst.Intro();
        }
    }

    class Tournament
    {
        public int ID;
        public string Name;
        public string Date;
        public string Address;
        public string City;
        public string State;
        public int MaxPlayers;

        // List of this tournament's games
        public List<Game> Games = new List<Game>();
    }

    // TODO Andy, this is your nested game class to code
    // - Fill in the info for needed stored for each game
    // - Should probably contain all data should on dropbox table plus hidden round value
    // - and anything else you think needs to be added.
    class Game 
    {

    }

    // TODO Grace, this is your player class to code
    class Players
    {

    }

    class Menu
    {

        public void Intro()
        {
            WriteLine("Hello! Please enter section you would like to use:" +
            " \n Enter 1 for Tournament Options \n Enter 2 for Player Options \n Enter 0 to Quit\n");

            string menuSelect = ReadLine().ToLower();
            
            switch (menuSelect)
            {
                case "1":
                    TournamentOptions();
                    break;
                case "2":
                    PlayersOptions();
                    break;
                case "0":
                    return;
                    break;
            }
        }

        // TODO Andy, this is our feature menu here, we will code this menu while Grace codes the player one
        // - focus on making the features and methods that modify game class data and keep track of the games of each tourney
        // - I'll try and focus on the overall data for the tournaments themselves and stuff that modifies them

        public void TournamentOptions()
        {
            WriteLine("Hello! Please enter the section of the application:" +
            " \nEnter 1 to Add a Tournament \nEnter 2 to Remove a Tournament \nEnter 3 to Add a Game to a Tournament \n" + 
            "Enter 0 to Quti");

            string tournMenuSelect = ReadLine().ToLower();

            switch (tournMenuSelect)
            {
                case "1":
                    AddTournament();
                    break;
                case "2":
                    RemoveTournament();
                    break;
                case "3":
                    AddGame();
                    break;
                case "0":
                    return;
                    break;
            }
        }

        // TODO Grace, this is your menu to code

        public void PlayersOptions()
        {
            WriteLine("\nPlayer Options\n");
        }

        public void AddTournament()
        {
            // Get the info for needed to start a tournament
            WriteLine("Please enter the name of the Tournament.\n");
            string tournName = ReadLine().ToLower();

            WriteLine("Please enter the start date of the Tournament.\n");
            string tournDate = ReadLine().ToLower();

            WriteLine("Please enter the Address of the Tournament.\n");
            string tournAddress = ReadLine().ToLower();

            WriteLine("Please enter the city location of the Tournament.\n");
            string tournCity = ReadLine().ToLower();

            WriteLine("Please enter the state location of the Tournament. (Abbreviated)\n");
            string tournState = ReadLine().ToLower();

            WriteLine("Please enter the maximum amount of players of the Tournament.\n");
            string tournMax = ReadLine().ToLower();          
        }

        public void RemoveTournament()
        {
            WriteLine("\nRemove Tournament");
        }

        public void AddGame()
        {
            WriteLine("\nAdd Game");
        }
    }
}


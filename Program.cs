using System;
using System.Collections.Generic;

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

        // TODO Andy, this is our feature menu here, we will code this menu while Grace codes the player one
        // - focus on making the features and methods that modify game class data and keep track of the games of each tourney
        // - I'll try and focus on the overall data for the tournaments themselves and stuff that modifies them

        public void TournamentOptions()
        {
            Console.WriteLine("Hello! Please enter the section of the application" +
            " you would like to use. \nYour choices are below. \n\nAdd Tournament | Remove Tournament | Remove Tournament |" +
            " Add Game\n");

            string tournMenuSelect = Console.ReadLine().ToLower();

            if (tournMenuSelect == "add tournament")
            {
                AddTournament();
            }
            else if (tournMenuSelect == "remove tournament")
            {
                RemoveTournament();
            }
            else if (tournMenuSelect == "add game")
            {
                AddGame();
            }
        }

        // TODO Grace, this is your menu to code

        public void PlayersOptions()
        {
            Console.WriteLine("\nPlayer Options\n");
        }

        public void AddTournament()
        {
            Console.WriteLine("\nAdd Tournament");         
        }

        public void RemoveTournament()
        {
            Console.WriteLine("\nRemove Tournament");
        }

        public void AddGame()
        {
            Console.WriteLine("\nAdd Game");
        }
    }
}


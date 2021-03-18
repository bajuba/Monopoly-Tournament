using System;
using System.Collections.Generic;
using static System.Console;
using Monopoly;
using System.Linq;

namespace Monopoly
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menuInst = new Menu();
            /*Tournament tourneys = new Tournament();*/

            //get tournament data if the tournament list is empty
            if (!TournamentList.Tournaments.Any()){
                    GetTournamentData.GetData();
                }
            
            menuInst.Intro(menuInst/*, tourneys*/);
        }
    }

    public class Menu
    {
        public void Intro(Menu menuInst/*, Tournament tourneys*/)
        {
            WriteLine("Hello! Please enter section you would like to use:" +
            " \n Enter 1 for Tournament Options \n Enter 2 for Player Options \n Enter 0 to Quit\n");

            string menuSelect = ReadLine().ToLower();
            
            switch (menuSelect)
            {
                case "1":
                    /*TournamentOptions(menuInst, tourneys);*/
                    ViewTournament.View();
                    break;
                case "2":
                    PlayersOptions();
                    break;
                case "0":
                    return;
                 default:
                    WriteLine("\nI'm sorry that is not an option, please try again.\n\n");
                    Intro(menuInst/*, tourneys*/);
                    break;
            }
        }

        // TODO Andy, this is our feature menu here, we will code this menu while Grace codes the player one
        // - focus on making the features and methods that modify game class data and keep track of the games of each tourney
        // - I'll try and focus on the overall data for the tournaments themselves and stuff that modifies them

        /*public void TournamentOptions(Menu menuInst, Tournament tourneys)
        {
            WriteLine("Hello! Please enter the section of the application:" +
            " \nEnter 1 to Add a Tournament \nEnter 2 to Remove a Tournament \nEnter 3 to Add a Game to a Tournament \n" + 
            "Enter 0 to go back");

            string tournMenuSelect = ReadLine().ToLower();

            switch (tournMenuSelect)
            {
                case "1":
                    tourneys.AddTournament(menuInst, tourneys);
                    break;
                case "2":
                    tourneys.RemoveTournament(menuInst, tourneys);
                    break;
                case "3":
                    AddGame();
                    break;
                case "0":
                    Intro(menuInst, tourneys);
                    break;
                default:
                    WriteLine("\nI'm sorry that is not an option, please try again.\n\n");
                    TournamentOptions(menuInst, tourneys);
                    break;
            }
        }*/

        // TODO Grace, this is your menu to code

        public void PlayersOptions()
        {
            WriteLine("\nPlayer Options\n");
        }

        public void AddGame()
        {
            WriteLine("\nAdd Game");
        }
    }
}
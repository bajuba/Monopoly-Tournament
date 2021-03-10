using System;
using System.IO;
using System.Collections.Generic;
using static System.Console;
using Monopoly;

namespace Monopoly
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menuInst = new Menu();

            PlayerClass newPlayer;

            using(StreamReader reader = new StreamReader(@"playerInfo.csv")){
                while (!reader.EndOfStream){
          
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');
                    newPlayer = new PlayerClass(values[0],values[1], values[2], values[3], values[4], values[5], "0", values[6], values[7],
                    values[8], values[9], values[10], values[11], values[12], values[13]);
          
                    PlayerList.Players.Add(newPlayer);
                    }
                }
            
            
            menuInst.Intro(menuInst);
        }
    }

    public class Menu
    {

        public void Intro(Menu menuInst)
        {
            WriteLine("Hello! Please enter section you would like to use:" +
            " \n Enter 1 for Tournament Options \n Enter 2 for Player Options \n Enter 0 to Quit\n");

            string menuSelect = ReadLine().ToLower();
            
            switch (menuSelect)
            {
                case "1":
                    break;
                case "2":
                    PlayersOptions(menuInst);
                    break;
                case "0":
                    return;
                 default:
                    WriteLine("\nI'm sorry that is not an option, please try again.\n\n");
                    Intro(menuInst);
                    break;
            }
        }

        // TODO Andy, this is our feature menu here, we will code this menu while Grace codes the player one
        // - focus on making the features and methods that modify game class data and keep track of the games of each tourney
        // - I'll try and focus on the overall data for the tournaments themselves and stuff that modifies them

        public void TournamentOptions(Menu menuInst)
        {
            WriteLine("Hello! Please enter the section of the application:" +
            " \nEnter 1 to Add a Player \nEnter 2 to Remove a Player \nEnter 3 to edit player Info \nEnter 4 list all players info\n" + 
            "Enter 0 to go back");

            string tournMenuSelect = ReadLine().ToLower();

            switch (tournMenuSelect)
            {
                case "1":
                    
                    break;
                case "2":
                    
                    break;
                case "3":
                    
                    break;
                case "4":
                    
                    break;
                case "0":
                    Intro(menuInst);
                    break;
                default:
                    WriteLine("\nI'm sorry that is not an option, please try again.\n\n");
                    TournamentOptions(menuInst);
                    break;
            }
        }

        // TODO Grace, this is your menu to code

        public void PlayersOptions(Menu menuInst)
        {
            WriteLine("Hello! Please enter the section of the application:" +
            " \nEnter 1 to Add a Tournament \nEnter 2 to Remove a Tournament \nEnter 3 to Add a Game to a Tournament \n" + 
            "Enter 0 to go back");

            string tournMenuSelect = ReadLine().ToLower();

            switch (tournMenuSelect)
            {
                case "1":
                    
                    break;
                case "2":
                    
                    break;
                case "3":
                    PlayerList.AddPlayer(menuInst);
                    break;
                case "0":
                    Intro(menuInst);
                    break;
                default:
                    WriteLine("\nI'm sorry that is not an option, please try again.\n\n");
                    PlayersOptions(menuInst);
                    break;
            }
        }





        public void AddGame()
        {
            WriteLine("\nAdd Game");
        }
    }
}
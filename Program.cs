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
            // Menu Instance
            Menu menuInst = new Menu();

            // Player Class Instance
            PlayerClass newPlayer;

            // Player CSV Reader, feel free to move to external document reader method is you want Grace or Randy,
            // Also Richard feel free to make your tournament CSV in an external sheet also.
            using(StreamReader reader = new StreamReader(@"playerInfo.csv")){
                while (!reader.EndOfStream){
          
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');
                    newPlayer = new PlayerClass(values[1].Remove(values[1].Length - 1), values[0].Remove(0,1), values[2], values[3], values[4], values[5], "0", values[6], values[7],
                    values[8], values[9], values[10], values[11], values[12], values[13], values[14]);
          
                    PlayerList.Players.Add(newPlayer);
                    }
                }
            
            
            menuInst.Intro(menuInst);
        }
    }

    public class Menu
    {
        // Main Menu
        public void Intro(Menu menuInst)
        {
            WriteLine("\n\nHello! Please enter section you would like to use:" +
            " \n Enter 1 for Tournament Options \n Enter 2 for Player Options \n Enter 0 to Quit\n");

            string menuSelect = ReadLine().ToLower();
            
            switch (menuSelect)
            {
                case "1":
                    TournamentOptions(menuInst);
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

        // Richard here's you're menu to code in. Change it as you see fit. So far every option takes you back to the main menu.
        // Tournament Options Menu
        public void TournamentOptions(Menu menuInst)
        {
            WriteLine("\n\nHello! Please enter the section of the application:" +
            " \nEnter 0 to go back");

            string tournMenuSelect = ReadLine().ToLower();

            switch (tournMenuSelect)
            {
                case "1":
                    Intro(menuInst);
                    break;
                case "2":
                    Intro(menuInst);
                    break;
                case "3":
                    Intro(menuInst);
                    break;
                case "4":
                    Intro(menuInst);
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

        // TODO Grace & Randy, this is your menu to code in feel fre to change it as you progress. Unimplemented options will
        // just return you to the main menu.
        // Player Options Menu
        public void PlayersOptions(Menu menuInst)
        {
            WriteLine("\n\nHello! Please enter the section of the application:" +
            " \nEnter 1 to Nothing \nEnter 2 to See All Players \nEnter 3 to Nothing (Add Players) \n" + 
            "Enter 0 to go back");

            string tournMenuSelect = ReadLine().ToLower();

            switch (tournMenuSelect)
            {
                case "1":
                    Intro(menuInst);
                    break;
                case "2":
                    PlayerList.ViewPlayers(menuInst);
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



        // Richard, this will be the sub menu for adding/modifying the game data later on. Feel free to move or Edit it as you go.

        public void AddGame()
        {
            WriteLine("\nAdd Game");
        }
    }
}
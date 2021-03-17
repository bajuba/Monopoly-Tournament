using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.IO;

namespace Monopoly{
  public static class PlayerList {
    public static List<PlayerClass> Players = new List<PlayerClass>();

    public static void ViewPlayers(Menu menuInst)
    {
      WriteLine("Would you like to view all Players?" +
      "\n Yes or No?");
      string whileInput = ReadLine().ToLower();

      if (whileInput != "yes" && whileInput != "no") {
          ViewPlayers(menuInst);
      }

      else if (whileInput == "yes"){
          foreach (var player in Players) {
            WriteLine("Name: " + player.Name + " | ID: " + player.ID + " | Goojf Rank: " + 0);
            
            WriteLine("\n");
          }
      }

      WriteLine("\nReturning to menu.\n");
      menuInst.Intro(menuInst);
    }

    public static void AddPlayer(Menu menuInst)
    {
      WriteLine("Would you like to add a new Player?" +
      "\n Yes or No?");
      string whileInput = ReadLine().ToLower();

      if (whileInput != "yes" && whileInput != "no") {
          AddPlayer(menuInst);
      }

      else if (whileInput == "yes"){
          while (whileInput != "no") {
              if (whileInput == "yes"){
                  int id = 0;
                  // Get the info for needed to start a tournament
                  if (!Players.Any()){
                      id = 1;
                  }
                  else  {
                       var lastList = Int32.Parse(Players.Last().ID);
                       id = lastList + 1;
                  }

                  WriteLine("\nPlease enter the name of the Player.");
                  string playerName = ReadLine().ToLower();

                  // Get Todays Date
                  DateTime joinDate = DateTime.Today;

                  WriteLine("\nPlease enter Date of birth Month/Day/Year");
                  string playerBirth = ReadLine().ToLower();

                  WriteLine("\nPlease enter the home town of the player.");
                  string playerTown = ReadLine().ToLower();

                  WriteLine("\nPlease enter the state location of the home town. (Abbreviated)");
                  string playerState = ReadLine().ToLower();

                  // Set Get out of Jail Free rank
                  string goojfRank = "0";

                  WriteLine("\nPlease enter most preferred monopoly piece.\n" + 
                  "Car | Iron | Shoe | Ship | Thimble | Wheelbarrow | Top Hat | Dog");
                  string piece1 = ReadLine().ToLower();  
                  
                  WriteLine("\nPlease enter 2nd most preferred monopoly piece.\n" + 
                  "Car | Iron | Shoe | Ship | Thimble | Wheelbarrow | Top Hat | Dog");
                  string piece2 = ReadLine().ToLower();

                  WriteLine("\nPlease enter 3rd most preferred monopoly piece.\n" + 
                  "Car | Iron | Shoe | Ship | Thimble | Wheelbarrow | Top Hat | Dog");
                  string piece3 = ReadLine().ToLower();

                  WriteLine("\nPlease enter 4th most preferred monopoly piece.\n" + 
                  "Car | Iron | Shoe | Ship | Thimble | Wheelbarrow | Top Hat | Dog");
                  string piece4 = ReadLine().ToLower();

                  WriteLine("\nPlease enter 5th most preferred monopoly piece.\n" + 
                  "Car | Iron | Shoe | Ship | Thimble | Wheelbarrow | Top Hat | Dog");
                  string piece5 = ReadLine().ToLower();

                  WriteLine("\nPlease enter 6th most preferred monopoly piece.\n" + 
                  "Car | Iron | Shoe | Ship | Thimble | Wheelbarrow | Top Hat | Dog");
                  string piece6 = ReadLine().ToLower();

                  WriteLine("\nPlease enter 7th most preferred monopoly piece.\n" + 
                  "Car | Iron | Shoe | Ship | Thimble | Wheelbarrow | Top Hat | Dog");
                  string piece7 = ReadLine().ToLower();

                  WriteLine("\nPlease enter 8th most preferred monopoly piece.\n" + 
                  "Car | Iron | Shoe | Ship | Thimble | Wheelbarrow | Top Hat | Dog");
                  string piece8 = ReadLine().ToLower();

                  // Add tournament list to tournaments list
                  PlayerClass addPlayer = new PlayerClass(playerName, id.ToString(), joinDate.ToString("d-MMM-yyyy"), playerBirth, playerTown,
                  playerState, goojfRank, piece1, piece2, piece3, piece4, piece5, piece6, piece7, piece8);
                  PlayerList.Players.Add(addPlayer);

                  WriteLine("\nWould you like to add another tournament?" +
                  "\n Yes or No?");
                  whileInput = ReadLine().ToLower(); 
              }
              else {
                  WriteLine("\nPlease enter yes or no.");
                  whileInput = ReadLine().ToLower();
              }
          }
          foreach (var player in Players) {
            WriteLine(player.Name);
            
            WriteLine("\n");
          }
      }

      WriteLine("\nReturning to menu.\n");
      menuInst.Intro(menuInst);
    }
  }

}
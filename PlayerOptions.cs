using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.IO;

namespace PlayerOptions{
  class PlayerClass {
    string optionSelect;

    public static void Main () {
      WriteLine("Welcome to Player Options");
      WriteLine("-------------------------");
      WriteLine("Enter 1 to add players.");
      WriteLine("Enter 2 to remove players.");
      WriteLine("Enter 3 to edit a player(s).");
      WriteLine("Enter 4 to return to menu.")
      WriteLine("-------------------------");
      WriteLine("Type here: ");
      optionSelect = ReadLine();

      switch(optionSelect){
        case "1":
          AddPlayer();
          return true;
          break;
        case "2":
          RemovePlayer();
          return true;
          break;
        case "3":
          EditPlayer();
          return true;
          break;
        case "4":
          Clear();
          Main();
          return true;
          break;
        default:
          Clear();
          WriteLine("Please try again: ");
          return true;
          break;
      }
    }
  }

  class PlayerList{
    public static void ListCommands(){
      List <string> playersList = new List<string>;
      string playerSurname;
      string playerFirstMidName;
      int playerID;
      string playerBirthdate;
      string dateJoined;
      string playerTown;
      string playerState;
      //Player pieces will be a list, 0-7
      List <string> playerPieces = new List<string>;
      
    }
    private static void AddPlayer(){

    }
    private static void DeletePlayer(){

    }
    private static void EditPlayer(){

    }
  }
}
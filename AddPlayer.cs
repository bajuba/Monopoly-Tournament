using System;
using System.Collections.Generic;
using static System.Console;

class AddPlayer {
  public static void Main () {
    List<string> playersList = new List<string>();
    string fullName;
    string preferredPiece;
    string playerInfo = null;
    string whileAddConfirm;

    WriteLine("Are you sure you want to add a new player? (y/n): ");
    whileAddConfirm = ReadLine();

    if(whileAddConfirm != "y" && whileAddConfirm != "n"){
      WriteLine("Please try again (y/n): ");
      whileAddConfirm = ReadLine();
    }
    else if(whileAddConfirm == "y"){
      while (whileAddConfirm != "n"){
      WriteLine("Insert player's full name: ");
      fullName = ReadLine();
      WriteLine("What is the player's preferred piece?: ");
      preferredPiece = ReadLine();

      playerInfo = fullName + " : " + preferredPiece; 
      playersList.Add(playerInfo);

      WriteLine("Do you want to add another player? (y/n): ");
      whileAddConfirm = ReadLine();
        }
      }
      WriteLine("Ok. Printing current players in list:");
      WriteLine("-----------------------------");
      foreach(var i in playersList){
        WriteLine(i);
      }
    }
   }

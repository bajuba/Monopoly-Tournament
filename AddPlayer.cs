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

    while (whileAddConfirm != "n"){
      WriteLine("Insert player's full name: ");
      fullName = ReadLine();
      WriteLine("What is the player's preferred piece?: ");
      preferredPiece = ReadLine();

      playerInfo = fullName + " " + preferredPiece; 
      playersList.Add(playerInfo);

      WriteLine("Do you want to add another player? (y/n): ");
      whileAddConfirm = ReadLine();
    }
    WriteLine(playerInfo);
  }
}
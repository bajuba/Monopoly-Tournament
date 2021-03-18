using System;
using System.Collections.Generic;
using System.Linq;

namespace Monopoly
{
  //collects tournament information from the user and stores it in a new tournament object
  public class NewTournament
  {
    public static void New()
    {
      string enteredData;
      bool valid = false;
      int converted;
      List<string> prompts = new List<string>{"ID: ", "Name: ", "Date: ", "Address: ", "City: ", "State: ", "Max players: ", "Last Space: ", "Winning Token: ", "First Place: ", "Second Place: ", "Third Place: ", "Fourth Place: "};
      List<string> dataList = new List<string>();
      Tournament newTournament;

      //clear list of entered data
      dataList.Clear();
      
      //collect user input
      foreach (string prompt in prompts){
        Console.Clear();
        Console.WriteLine("Enter tournament data:");
        Console.WriteLine("\n" + prompt);
        enteredData = Console.ReadLine();

        //makes sure player counts and IDs are non negative intigers
        if (prompts.IndexOf(prompt) == 0 || prompts.IndexOf(prompt) == 6){
          while (!valid){
            if (int.TryParse(enteredData, out converted) && converted > 0){
              valid = true;
            }
            else{
              Console.Clear();
              Console.WriteLine("Enter tournament data:");
              Console.WriteLine("\nError: invalid input");
              Console.WriteLine("\n" + prompt);
              enteredData = Console.ReadLine();
            }
          }
          valid = false;
        }

        dataList.Add(enteredData);
      }
      //create new tournament with user data
      newTournament = new Tournament(dataList[0], dataList[1], dataList[2], dataList[3], dataList[4], dataList[5], Int32.Parse(dataList[6]), dataList[7], dataList[8], dataList[9], dataList[10], dataList[11], dataList[12]);
      TournamentList.Tournaments.Add(newTournament);

      Console.Clear();
      Console.WriteLine("New tournament created:");
      Console.WriteLine(newTournament);
      
      Console.ReadLine();
    }
  }
}
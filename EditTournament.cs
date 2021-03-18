using System;
using System.Collections.Generic;
using System.Linq;

namespace Monopoly
{
  //the user can select a tournament, choose a field, and edit it
  public class EditTournament
  {  
    public static void Edit(Tournament tournament)
    {
      bool valid = false;
      int converted;
      string playerCount;
      string toEdit = "";

      while (toEdit != "q"){
        Console.Clear();

        Console.WriteLine("\nWhat to edit:");
        Console.WriteLine("\n1. Name \n2. Date \n3. Address \n4. City \n5. State \n6. Max players \n7. Last space \n8. Winning token \n9. First place \n10. Second place \n11. Third place \n12. Fourth place \n\n[q] quit");

        toEdit = Console.ReadLine();
        
        Console.Clear();

        switch(toEdit){
          case "1":
            Console.WriteLine("\nEnter new name:");
            tournament.Name = Console.ReadLine();
            break;
          case "2":
            Console.WriteLine("\nEnter new date:");
            tournament.TournamentDate = Console.ReadLine();
            break;
          case "3":
            Console.WriteLine("\nEnter new address:");
            tournament.Address = Console.ReadLine();
            break;
          case "4":
            Console.WriteLine("\nEnter new city:");
            tournament.City = Console.ReadLine();
            break;
          case "5":
          Console.WriteLine("\nEnter new state:");
            tournament.State = Console.ReadLine();
            break;
          case "6":
            Console.WriteLine("\nEnter new max player amount:");

            //makes sure player count is a non negative intiger
            while (!valid){
              playerCount = Console.ReadLine();
              if (int.TryParse(playerCount, out converted) && converted > 0){
                tournament.MaxPlayers = Int32.Parse(playerCount);
                valid = true;
              }
              else{
                Console.Clear();
                Console.WriteLine("\nError: invalid input");
                Console.WriteLine("\nEnter new max player amount:");
              }
            }
            valid = false;
            break;
          case "7":
            Console.WriteLine("\nEnter new last space:");
            tournament.LastSpace = Console.ReadLine();
            break;
          case "8":
            Console.WriteLine("\nEnter new winning token:");
            tournament.Token = Console.ReadLine();
            break;
          case "9":
            Console.WriteLine("\nEnter new first place winner:");
            tournament.FirstPlace = Console.ReadLine();
            break;
          case "10":
            Console.WriteLine("\nEnter new second place winner:");
            tournament.SecondPlace = Console.ReadLine();
            break;
          case "11":
            Console.WriteLine("\nEnter new third place winner:");
            tournament.ThirdPlace = Console.ReadLine();
            break;
          case "12":
            Console.WriteLine("\nEnter new fourth place winner:");
            tournament.FourthPlace = Console.ReadLine();
            break;
        }
      }
    }
  }
}
using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;

namespace Monopoly
{
    class Tournament
    {
        List<List<string>> tournaments = new List<List<string>>();

        // Info Position: 0 = ID, 1 = Name, 2 = Start Date, 3 = Address, 4 = City, 5 = State, 6 = Max Entrants,
        // 7 = Last Space, 8 = First Place Token, 9 = First Place Player, 10 = Second Place Player, 11 = Third Place Player,
        // 12 = Fourth Place Player
        List<string> tournament = new List<string>();

        public void AddTournament(Menu menuInst, Tournament tourneys)
        {
            WriteLine("Would you like to add a new Tournament?" +
            "\n Yes or No?");
            string whileInput = ReadLine().ToLower();

            if (whileInput != "yes" && whileInput != "no") {
                AddTournament(menuInst, tourneys);
            }

            else if (whileInput == "yes"){
                while (whileInput != "no") {
                    if (whileInput == "yes"){
                        int id = 0;
                        tournament = new List<string>();

                        // Get the info for needed to start a tournament
                        if (!tournaments.Any()){
                            id = 1;
                            tournament.Insert(0, id.ToString());
                        }
                        else  {
                            var lastList = Int32.Parse(tournaments.Last().First());
                            id = lastList + 1;
                            tournament.Insert(0, id.ToString());
                        }

                        WriteLine("\nPlease enter the name of the Tournament.");
                        string tournName = ReadLine().ToLower();
                        tournament.Insert(1, tournName);

                        WriteLine("\nPlease enter the start date of the Tournament.");
                        string tournDate = ReadLine().ToLower();
                        tournament.Insert(2, tournDate);

                        WriteLine("\nPlease enter the Address of the Tournament.");
                        string tournAddress = ReadLine().ToLower();
                        tournament.Insert(3, tournAddress);

                        WriteLine("\nPlease enter the city location of the Tournament.");
                        string tournCity = ReadLine().ToLower();
                        tournament.Insert(4, tournCity);

                        WriteLine("\nPlease enter the state location of the Tournament. (Abbreviated)");
                        string tournState = ReadLine().ToLower();
                        tournament.Insert(5, tournState);

                        WriteLine("\nPlease enter the maximum amount of players of the Tournament.");
                        string tournMax = ReadLine().ToLower();  
                        tournament.Insert(6, tournMax);

                        // Fill in other information until determined
                        for (int l = 7; l < 13; l++){
                            tournament.Insert(l, "Not Determined");
                        }

                        // Add tournament list to tournaments list
                        tournaments.Insert(id - 1, tournament);

                        WriteLine("\nWould you like to add another tournament?" +
                        "\n Yes or No?");
                        whileInput = ReadLine().ToLower(); 
                    }
                    else {
                        WriteLine("\nPlease enter yes or no.");
                        whileInput = ReadLine().ToLower();
                    }
                }
            }

            WriteLine("\nReturning to menu.\n");
            menuInst.Intro(menuInst, tourneys);
        }

        public void RemoveTournament(Menu menuInst, Tournament tourneys){
            WriteLine("Would you like to remove a Tournament?" +
            "\n Yes or No?");
            string whileInput = ReadLine().ToLower();

            if (whileInput != "yes" && whileInput != "no") {
                AddTournament(menuInst, tourneys);
            }

            else if (whileInput == "yes"){
                while (whileInput != "no") {
                    if (whileInput == "yes"){
                        WriteLine("\nHere is a list of all the tournaments on record.\n");
                        foreach (var l in tournaments){
                            WriteLine("Tournament: {0} | ID: {1}", l[1], l[0]);
                        }

                        WriteLine("\nPlease enter the ID number of the tournament you would like to delete.");
                        string stringInput = ReadLine().ToLower();
                        int q;
                        if (!Int32.TryParse(stringInput, out q)){
                            WriteLine("\n\n\n\n\n\n\n\n\nPlease enter a number.");
                        }
                        else if (q > tournaments.Count() || q < 1){
                            WriteLine("\n\n\n\n\n\n\n\n\nPlease enter a valid tournament ID.");
                        }
                        else{
                            int removeInput = Int32.Parse(stringInput);

                            for (int i = 0; i < tournaments.Count(); i++){
                                if (Int32.Parse(tournaments[i][0]) == removeInput) {
                                    tournaments.RemoveAt(removeInput - 1);
                                    for (int x = 0; x < tournaments.Count(); x++){
                                        if (Int32.Parse(tournaments[x][0]) != x + 1){
                                            tournaments[x][0] = (x + 1).ToString();
                                        }
                                    }
                                }
                            }

                            WriteLine("\nWould you like to remove another tournament?" +
                            "\n Yes or No?");
                            whileInput = ReadLine().ToLower(); 
                        }
                    }
                    else {
                        WriteLine("\nPlease enter yes or no.");
                        whileInput = ReadLine().ToLower();
                    }

                }
            }

            WriteLine("\n\n\n\n\nReturning to menu.\n");
            menuInst.Intro(menuInst, tourneys);
        }

    }
}
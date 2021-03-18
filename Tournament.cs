using System;

namespace Monopoly
{
  public class Tournament
  {
    public string TournamentID{get;set;}
    public string Name{get; set;}
    public string TournamentDate{get;set;}
    public string Address{get; set;}
    public string City{get;set;}
    public string State{get;set;}
    public int MaxPlayers{get; set;}
    public string LastSpace{get;set;}
    public string Token{get;set;}
    public string FirstPlace{get;set;}
    public string SecondPlace{get;set;}
    public string ThirdPlace{get;set;}
    public string FourthPlace{get;set;}

    public Tournament()
    {
      TournamentID = "";
      Name = "";
      TournamentDate = "";
      Address = "";
      City = "";
      State = "";
      MaxPlayers = 0;
      LastSpace = "";
      Token = "";
      FirstPlace = "";
      SecondPlace = "";
      ThirdPlace = "";
      FourthPlace = "";
    }

    public Tournament(string inTournamentID, string inName, string inDate, string inAddress, string inCity, string inState, int inMaxPlayers, string inLastSpace, string inToken, string inFirstPlace, string inSecondPlace, string inThirdPlace, string inFourthPlace)
    {
      TournamentID = inTournamentID;
      Name = inName;
      TournamentDate = inDate;
      Address = inAddress;
      City = inCity;
      State = inState;
      MaxPlayers = inMaxPlayers;
      LastSpace = inLastSpace;
      Token = inToken;
      FirstPlace = inFirstPlace;
      SecondPlace = inSecondPlace;
      ThirdPlace = inThirdPlace;
      FourthPlace = inFourthPlace;
    }

    public override string ToString()
    {
      string printString = "";
      printString += "\nID:\t\t" + TournamentID; 
      printString += "\nName:\t\t" + Name;
      printString += "\nDate:\t\t" + TournamentDate;
      printString += "\nAddress:\t" + Address;
      printString += "\nCity:\t\t" + City;
      printString += "\nState:\t\t" + State;
      printString += "\nMax Players:\t" + MaxPlayers;
      printString += "\nLast Space:\t" + LastSpace;
      printString += "\nWinning Token:\t" + Token;
      printString += "\nFirst Place:\t" + FirstPlace;
      printString += "\nSecond Place:\t" + SecondPlace;
      printString += "\nThird Place:\t" + ThirdPlace;
      printString += "\nFourth Place:\t" + FourthPlace;
      return printString;
    }
  }
}

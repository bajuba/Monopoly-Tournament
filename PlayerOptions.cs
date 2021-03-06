using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.IO;

namespace PlayerClass{

  public class PlayerClass{
    public string Name {get;set;}
    public int ID {get;set;}
    public string JoinDate {get;set;}
    public string BirthDate {get;set;}
    public string State {get;set;}
    public List<string> Pieces = new List<string>(){get;set;}
    public int JailRank {get;set;}

    public PlayerClass(string name, int id, string joinDate, string birthDate, string state, List<string> pieces, int jailRank){
      Name = name;
      ID = id;
      JoinDate = joinDate;
      BirthDate = birthDate;
      State = state;
      Pieces = pieces;
      JailRank = jailRank;
    }

    public override string ToString(){
      string output = "";
      output += ($"Name : {Name}\n");
      output += ($"ID : {ID}\n");
      output += ($"JoinDate : {JoinDate}\n");
      output += ($"BirthDate : {BirthDate}\n");
      output += ($"State : {State}\n");
      output += ($"Pieces : {Pieces}\n");
      output += ($"Jail ank : {JailRank}");
      return output;
    }
  }
}
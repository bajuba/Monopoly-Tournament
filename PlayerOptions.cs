using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.IO;

namespace Monopoly{

  public class PlayerClass{
    public string Name {get;set;}
    public string ID {get;set;}
    public string JoinDate {get;set;}
    public string BirthDate {get;set;}
    public string HomeTown {get;set;}
    public string State {get;set;}
    public string JailRank {get;set;}
    public string Piece1 {get;set;}
    public string Piece2 {get;set;}
    public string Piece3 {get;set;}
    public string Piece4 {get;set;}
    public string Piece5 {get;set;}
    public string Piece6 {get;set;}
    public string Piece7 {get;set;}
    public string Piece8 {get;set;}

    public PlayerClass(string name, string id, string joinDate, string birthDate, string homeTown, string state, string jailRank, string piece1, string piece2, string piece3,
    string piece4, string piece5, string piece6, string piece7, string piece8){
      Name = name;
      ID = id;
      JoinDate = joinDate;
      BirthDate = birthDate;
      HomeTown = homeTown;
      State = state;
      JailRank = jailRank;
      Piece1 = piece1;
      Piece2 = piece2;
      Piece3 = piece3;
      Piece4 = piece4;
      Piece5 = piece5;
      Piece6 = piece6;
      Piece7 = piece7;
      Piece8 = piece8;
    }

    public override string ToString(){
      string output = "";
      output += ($"Name : {Name}\n");
      output += ($"ID : {ID}\n");
      output += ($"JoinDate : {JoinDate}\n");
      output += ($"BirthDate : {BirthDate}\n");
      output += ($"HomeTown : {HomeTown}\n");
      output += ($"State : {State}\n");
      output += ($"JailRank : {JailRank}");
      output += ($"Piece1 : {Piece1}\n");
      output += ($"Piece2 : {Piece2}\n");
      output += ($"Piece3 : {Piece3}\n");
      output += ($"Piece4 : {Piece4}\n");
      output += ($"Piece5 : {Piece5}\n");
      output += ($"Piece6 : {Piece6}\n");
      output += ($"Piece7 : {Piece7}\n");
      output += ($"Piece8 : {Piece8}\n");
      return output;
    }
  }
}
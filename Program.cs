namespace Burning
{
  using Burning.Models;
  using LiteDB;
  ﻿using System;

  public class Program
  {
    public void Initialize()
    {
      // ConsoleHelper.WriteLine(Globals.Title, ConsoleColor.Cyan);

      /*using(var db = new LiteDatabase(Globals.DataFile))
      {
        var col = db.GetCollection<Location>("locations");

        var myLocation = new Location
        {
          Id = Guid.NewGuid(),
          Name = "da name"
        };

        col.Insert(myLocation);
      }*/

      Console.Clear();
      ConsoleHelper.ShowTitle();
    }

    public void Run()
    {
      while(true)
      {
        var command = ConsoleHelper.ReadCommand();
        if (command == "quit" || command == "q") {
          break;
        }
      }
    }

    public static void Main(string[] args)
    {
      var prog = new Program();
      prog.Initialize();
      prog.Run();
    }
  }
}

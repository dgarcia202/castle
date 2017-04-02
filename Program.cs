namespace Burning
{
  using Burning.Models;
  using LiteDB;
  ﻿using System;

  public class Program
  {
    public void Initialize()
    {
      var myLocation = new Location
      {
        Id = Guid.NewGuid(),
        Name = "Oubliette",
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer congue id metus sed lobortis. Fusce massa justo, egestas quis aliquet non, ullamcorper in purus. In facilisis tincidunt euismod."
      };

      using(var db = new LiteDatabase(Globals.DataFile))
      {
        var col = db.GetCollection<Location>("locations");
        col.Insert(myLocation);
      }

      Console.Clear();
      ConsoleHelper.ShowTitle();
      ConsoleHelper.ShowLocation(myLocation);
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

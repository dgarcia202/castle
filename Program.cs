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
          Name = "da name",
          Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer congue id metus sed lobortis. Fusce massa justo, egestas quis aliquet non, ullamcorper in purus. In facilisis tincidunt euismod."
        };

        col.Insert(myLocation);
      }*/

      var myLocation = new Location
      {
        Id = Guid.NewGuid(),
        Name = "da name",
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer congue id metus sed lobortis. Fusce massa justo, egestas quis aliquet non, ullamcorper in purus. In facilisis tincidunt euismod."
      };

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

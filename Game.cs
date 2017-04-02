namespace Burning
{
  using Burning.Models;
  using LiteDB;
  ﻿using System;
  using System.Linq;

  public class Game
  {
    private DatabaseHelper databaseHelper = new DatabaseHelper();

    public void Initialize()
    {
      this.databaseHelper.Initialize();

      var startingLocation = this.databaseHelper.LoadLocation(Globals.StartingLocation);

      Console.Clear();
      ConsoleHelper.ShowTitle();
      ConsoleHelper.ShowLocation(startingLocation);
    }

    public void Run()
    {
      while(true)
      {
        var command = ConsoleHelper.ReadCommand();
        if (Globals.QuitCommand.Any(x => x == command)) {
          break;
        }
      }
    }
  }
}

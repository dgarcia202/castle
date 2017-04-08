namespace Burning
{
  using Burning.Objects;
  using Burning.Syntax;
  using LiteDB;
  ﻿using System;
  using System.Linq;

  public class Game
  {
    private DatabaseHelper databaseHelper = new DatabaseHelper();
    private SyntaxAnalizer syntaxAnalizer = new SyntaxAnalizer();
    private Player player;

    public void Initialize()
    {
      this.databaseHelper.Initialize();
      var startingLocation = this.databaseHelper.LoadLocation(Globals.StartingLocation);
      this.player = new Player(startingLocation);

      Console.Clear();
      ConsoleHelper.ShowTitle();
      ConsoleHelper.ShowLocation(this.player.CurrentLocation);
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

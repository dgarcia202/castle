namespace Burning
{
  using Burning.Models;
  using LiteDB;
  ﻿using System;
  using System.Linq;

  public class Program
  {
    public void Initialize()
    {
      var databaseHelper = new DatabaseHelper();
      databaseHelper.Initialize();

      Console.Clear();
      ConsoleHelper.ShowTitle();
      ConsoleHelper.ShowLocation(myLocation);
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

    public static void Main(string[] args)
    {
      var prog = new Program();
      prog.Initialize();
      prog.Run();
    }
  }
}

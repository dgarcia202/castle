namespace Burning
{
  using Burning.Objects;
  using LiteDB;
  ﻿using System;
  using System.Linq;

  public class Program
  {
    public static void Main(string[] args)
    {
      var game = new Game();
      game.Initialize();
      game.Run();
    }
  }
}

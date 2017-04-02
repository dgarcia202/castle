using System;
using System.Collections.Generic;

namespace Burning
{
  public static class Globals
  {
    public static string DataFile = @".\gamedata.db";
    public static string Prompt = ">> ";

    public static string Title = " My Placeholder Title";
    public static string MainCharacterName = "Elon";
    public static Guid StartingLocation = new Guid("ffc8bb12-772f-46aa-a209-c341e71a7b9f");

    public static ConsoleColor TitleColor = ConsoleColor.Cyan;
    public static ConsoleColor LocationColor = ConsoleColor.Yellow;

    public static IList<string> QuitCommand = new List<string> { "quit", "q" };
  }
}

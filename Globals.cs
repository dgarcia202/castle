using System;
using System.Collections.Generic;

namespace Burning
{
  public static class Globals
  {
    public static string Title = " My Placeholder Title";
    public static string MainCharacterName = "Elon";
    public static string DataFile = @".\gamedata.db";
    public static string Prompt = ">> ";

    public static ConsoleColor TitleColor = ConsoleColor.Cyan;
    public static ConsoleColor LocationColor = ConsoleColor.Yellow;

    public static IList<string> QuitCommand = new List<string> { "quit", "q" };
  }
}

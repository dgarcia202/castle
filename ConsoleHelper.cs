namespace Burning
{
  using System;

  using Burning.Objects;

  public static class ConsoleHelper
  {
    public static void ShowTitle()
    {
      ConsoleHelper.Write(new String('*', Console.BufferWidth), Globals.TitleColor);
      ConsoleHelper.Write("*" + new String(' ', Console.BufferWidth - 2) + "*", Globals.TitleColor);
      var prevSpaceNum = (Console.BufferWidth - 2 - Globals.Title.Length) / 2;
      var postSpaceNum = (Console.BufferWidth - 2 - Globals.Title.Length) - prevSpaceNum;
      ConsoleHelper.Write("*" + new String(' ', prevSpaceNum) + Globals.Title.ToUpper() + new String(' ', postSpaceNum) + "*", Globals.TitleColor);
      ConsoleHelper.Write("*" + new String(' ', Console.BufferWidth - 2) + "*", Globals.TitleColor);
      ConsoleHelper.Write(new String('*', Console.BufferWidth), Globals.TitleColor);
      Console.WriteLine();
    }

    public static void ShowLocation(Location loc)
    {
      ConsoleHelper.WriteLine(loc.Name, Globals.LocationColor);
      ConsoleHelper.WriteLine(new String('=', loc.Name.Length), Globals.LocationColor);
      ConsoleHelper.WriteLine(loc.Description, Globals.LocationColor);
      Console.WriteLine();

      foreach(var item in loc.Items)
      {
        ConsoleHelper.WriteLine("Hay " + item.Name, Globals.LocationColor);
      }

      Console.WriteLine();
    }

    public static void WriteLine(string text, ConsoleColor foreColor)
    {
      var currentForeColor = Console.ForegroundColor;
      Console.ForegroundColor = foreColor;
      Console.WriteLine(text);
      Console.ForegroundColor = currentForeColor;
    }

    public static void Write(string text, ConsoleColor foreColor)
    {
      var currentForeColor = Console.ForegroundColor;
      Console.ForegroundColor = foreColor;
      Console.Write(text);
      Console.ForegroundColor = currentForeColor;
    }

    public static string ReadCommand()
    {
      Console.Write(Globals.Prompt);
      return Console.ReadLine().ToLower();
    }
  }
}

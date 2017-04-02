namespace Burning
{
  using LiteDB;
  using System;
  using System.IO;

  using Burning.Models;

  public class DatabaseHelper
  {
    public void Initialize()
    {
      if (!File.Exists(Globals.DataFile))
      {
        using(var db = new LiteDatabase(Globals.DataFile))
        {
          var col = db.GetCollection<Location>("locations");
          var contents = new Contents();

          foreach (var location in contents.Locations) {
            col.Insert(location);
          }
        }
      }
    }

    public Location LoadLocation(Guid locationId)
    {
      Location loadedLocation;
      using(var db = new LiteDatabase(Globals.DataFile))
      {
        var col = db.GetCollection<Location>("locations");
        loadedLocation = col.FindById(locationId);
      }
      return loadedLocation;
    }
  }
}

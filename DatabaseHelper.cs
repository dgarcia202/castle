namespace Burning
{
  using System;
  using System.IO;

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
          
          contents = null;
        }
      }
    }
  }
}

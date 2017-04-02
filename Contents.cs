namespace NamespaceName
{
  using System;
  using System.Collections.Generic;

  using Burning.Models;

  public class Contents
  {
    public IList<Location> Locations { get; set; }

    public Contents()
    {
      this.Locations = new List<Location>();
      this.Locations.Add(new Location
      {
        Id = new Guid("ffc8bb12-772f-46aa-a209-c341e71a7b9f"),
        Name = "Oubliette",
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer congue id metus sed lobortis. Fusce massa justo, egestas quis aliquet non, ullamcorper in purus. In facilisis tincidunt euismod."
      });
    }
  }
}

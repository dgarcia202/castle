namespace Burning
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
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer congue id metus sed lobortis. Fusce massa justo, egestas quis aliquet non, ullamcorper in purus. In facilisis tincidunt euismod.",
        Items = new List<Item>
        {
            new Item { Id = new Guid("d4ef1e68-59c1-478f-9350-786a516f758b"), Name = "fragmento afilado de cerámica", Description = "un trozo de un cuenco roto." }
        }
      });
    }
  }
}

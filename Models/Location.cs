namespace Burning.Models
{
  using System;
  using System.Collections.Generic;

  public class Location: GameObject
  {
    public IList<Item> Items { get; set; }

    public IList<Npc> Npcs { get; set; }

    public Location()
    {
      this.Items = new List<Item>();
      this.Npcs = new List<Npc>();
    }
  }
}

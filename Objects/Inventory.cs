namespace Burning.Objects
{
  using System;
  using System.Collections.Generic;

  public class Inventory
  {
    public IList<Item> Items { get; set; }

    public Inventory()
    {
      this.Items= new List<Item>();
    }
  }
}

namespace Burning.Objects
{
  using System;

  public class Player
  {
    public Inventory Inventory { get; private set; }

    public Location CurrentLocation { get; private set; }

    public Player(Location startingLocation)
    {
      this.Inventory = new Inventory();
      this.CurrentLocation = startingLocation;
    }
  }
}

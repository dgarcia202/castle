namespace Burning.Objects
{
  using System;

  public abstract class GameObject
  {
    public Guid Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }
  }
}

using System;

namespace InheritanceIntro
{
  public class Vehicle
  {
    public string MainColor { get; set; }
    public int MaximumOccupancy { get; set; }

    public virtual void Drive()
    {
      Console.WriteLine("Vroom!");
    }

    public virtual void Turn(string direction)
    {
      Console.WriteLine($"Makes a zippy {direction} turn!");
    }

    public virtual void Stop()
    {
      Console.WriteLine("The vehicle gently rolls to a stop.!");
    }
  }
}
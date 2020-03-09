using System;

namespace InheritanceIntro
{
  public class Ram : Vehicle
  { // Gas powered truck
    public double FuelCapacity { get; set; }

    public void RefuelTank() { }

    public override void Drive()
    {
      Console.WriteLine($"The {MainColor} Ram growls by you! Zoom!");
    }

    public override void Turn(string direction)
    {
      Console.WriteLine($"All {MaximumOccupancy} passengers are holding on for dear life after this exhilarating {direction} turn!");
    }
  }
}
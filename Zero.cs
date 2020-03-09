using System;

namespace InheritanceIntro
{
  public class Zero : Vehicle
  {
    public double BatteryKWh { get; set; }

    public void ChargeBattery() { }

    public override void Drive()
    {
      Console.WriteLine($"The {MainColor} Zero zips past you! Neeeor!");
    }
    public override void Stop()
    {
      Console.WriteLine($"The {MainColor} Zero rolls to a stop into the parking lot.");
    }
  }
}
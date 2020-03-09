using System;

namespace InheritanceIntro
{
  public class Tesla : Vehicle
  { // Electric car
    public double BatteryKWh { get; set; }

    public void ChargeBattery() { }
    public override void Drive()
    {
      Console.WriteLine($"The {MainColor} Tesla zips past you! Rumble rumble!");
    }

    public override string ToString()
    {
      return "This is my Tesla!";
    }
  }
}
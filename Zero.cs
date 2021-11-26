using System;

namespace Garage
{
    public class Zero : Vehicle  // Electric motorcycle
    {
        public double BatteryKWh { get; set; }
        public void ChargeBattery()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine("Zippity Zip Zip Zoom...");
        }

        public override void Turn(string direction)
        {
            base.Turn(direction);
            Console.WriteLine("and it's Tokyo Drifting. I didn't think a motorcycle could do that.");
        }
    }
}

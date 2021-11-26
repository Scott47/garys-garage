using System;

namespace Garage
{
    public class Zero : Vehicle, IElectric // Electric motorcycle
    {
        public double BatteryKWh { get; set; }

        public double CurrentChargePercentage { get; set; }
        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
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
